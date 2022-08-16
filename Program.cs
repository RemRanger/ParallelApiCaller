using System.Configuration;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text.Json;

const int callCount = 500;

var token = await GetToken();
if (string.IsNullOrWhiteSpace(token))
{
    return;
}

var url = ConfigurationManager.AppSettings["base_url"] + "/" + ConfigurationManager.AppSettings["path_url"];

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

Console.WriteLine($"Creating {callCount} tasks...");
var tasks = new Task<HttpResponseMessage>[callCount];
for (int i = 0; i < callCount; i++)
{
    var id = Guid.NewGuid().ToString()/*$"00000000-0000-0000-0000-000000000{i:D3}"*/;
    var jsonN = TestData.Example_MilkingVisit_Gea_20220621.Replace(TestData.Example_MilkingVisit_Gea_20220621_Id1, id);
    var httpContent = new StringContent(jsonN);
    httpContent!.Headers!.ContentType!.MediaType = "application/json";

    tasks[i] = httpClient.PostAsync(url, httpContent);
}

Console.WriteLine();
Console.WriteLine("Executing tasks...");

var stopwatch = new Stopwatch();
stopwatch.Start();

await Task.WhenAll(tasks);

stopwatch.Stop();

Console.WriteLine($"Executing tasks took {stopwatch.ElapsedMilliseconds / 1000.0:N3} s.");
Console.WriteLine();

Console.WriteLine("Results:");
foreach (var group in tasks.GroupBy(t => $"{(int)t.Result.StatusCode} {t.Result.ReasonPhrase}").OrderBy(g => g.Key))
{
    Console.WriteLine($"Number of tasks: {group.Count()} --> Result: {group.Key}");
}

static async Task<string> GetToken()
{
    string token = string.Empty;

    try
    {
        var tokenUrl = ConfigurationManager.AppSettings["base_url_token"] + "/" + ConfigurationManager.AppSettings["path_url_token"];
        var clientId = ConfigurationManager.AppSettings["client_id"]!;
        var clientSecret = ConfigurationManager.AppSettings["client_secret"]!;
        var grantType = ConfigurationManager.AppSettings["grant_type"]!;

        var data = new[]
        {
            new KeyValuePair<string, string>("client_id", clientId),
            new KeyValuePair<string, string>("client_secret", clientSecret),
            new KeyValuePair<string, string>("grant_type", grantType),
        };
        var httpTokenContent = new FormUrlEncodedContent(data);
        httpTokenContent!.Headers!.ContentType!.MediaType = "application/x-www-form-urlencoded";

        var httpClientToken = new HttpClient();

        var response = await httpClientToken.PostAsync(tokenUrl, httpTokenContent);

        if (!response.IsSuccessStatusCode)
        {
            Console.WriteLine($"Failed to get token: {response}");
        }

        var responseContent = await response.Content.ReadAsStringAsync();
        var responseDoc = JsonDocument.Parse(responseContent);
        token = responseDoc.RootElement.GetProperty("access_token").GetString() ?? string.Empty;

        Console.WriteLine(!string.IsNullOrWhiteSpace(token) ? $"Getting token successful." : "Token not found.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Getting token failed: {ex.GetType()} - {ex.Message}");
    }
    finally
    {
        Console.WriteLine();
    }

    return token;
}

