using System.Net.Http.Headers;

const string url = "http://localhost:5000/adapter-milking-visits/api/locations/nl.kvk/7000001/milking-visits";
const int N = 1;


var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TestData.BearerToken);

var tasks = new Task<HttpResponseMessage>[N];
for (int i = 0; i < N; i++)
{
    var jsonN = TestData.Example_MilkingVisit_Gea_20220621.Replace(TestData.Example_MilkingVisit_Gea_20220621_Id1, $"00000000-0000-0000-0000-000000000{i:D3}");
    var httpContent = new StringContent(jsonN);
    httpContent!.Headers!.ContentType!.MediaType = "application/json";

    Console.WriteLine($"Creating task {i}");
    tasks[i] = httpClient.PostAsync(url, httpContent);
}

Console.WriteLine();
Console.WriteLine("Executing tasks...");
Console.WriteLine();
await Task.WhenAll(tasks);

for (int i = 0; i < N; i++)
{
    var task = tasks[i];
    Console.WriteLine($"Task {i}: Result: {task.Result}");
}

