internal class TestData
{
    public const string BearerToken = "eyJhbGciOiJSUzI1NiIsInR5cCIgOiAiSldUIiwia2lkIiA6ICJtQVlSQ2pIcERiUUUxRm1nVFVDdnA2Z0RKM2gzQlZmZEVUeVpCQWR1Sk44In0.eyJleHAiOjE2NjA1NjI4ODQsImlhdCI6MTY2MDU2MTA4NCwianRpIjoiMjgzZDQxNGYtOWMyZS00NTRmLWI3MjgtMTBkNDk2NTA0ZmM2IiwiaXNzIjoiaHR0cHM6Ly90ZXN0LmpvaW4tZGF0YS5uZXQvYXV0aC9yZWFsbXMvZGF0YWh1YiIsImF1ZCI6WyJmYXJtZXItcmVtIiwiYWNjb3VudCJdLCJzdWIiOiJiYTU4ZmVlZC01ZDFlLTRlYmMtYTAwOS0zZGJkNGU5YzRhZmUiLCJ0eXAiOiJCZWFyZXIiLCJhenAiOiJmYXJtZXItcmVtIiwicmVzb3VyY2VfYWNjZXNzIjp7ImFjY291bnQiOnsicm9sZXMiOlsibWFuYWdlLWFjY291bnQiLCJtYW5hZ2UtYWNjb3VudC1saW5rcyIsInZpZXctcHJvZmlsZSJdfX0sInNjb3BlIjoicHJvZmlsZSBlbWFpbCBEYXRhc291cmNlX1Byb3ZpZGVycyBBcHBsaWNhdGlvbl9kZXZlbG9wZXJzIiwiYXBwbGljYXRpb25fY29tcGFueV9rZXlfdmFsdWUiOiI2NTkzMTA0MSIsImNsaWVudEhvc3QiOiIxMC4yNDAuMC42IiwiY2xpZW50SWQiOiJmYXJtZXItcmVtIiwiZW1haWxfdmVyaWZpZWQiOmZhbHNlLCJhcHBsaWNhdGlvbl9jb21wYW55X2ZpbHRlciI6dHJ1ZSwiYXBwbGljYXRpb25fY29tcGFueV9rZXlfc2NoZW1lIjoibmwua3ZrIiwicHJlZmVycmVkX3VzZXJuYW1lIjoic2VydmljZS1hY2NvdW50LWZhcm1lci1yZW0iLCJlbWJlZGRpbmciOnRydWUsImNvbXBhbnlfa2V5X3ZhbHVlIjoiNjU4NzU4NDIiLCJjbGllbnRBZGRyZXNzIjoiMTAuMjQwLjAuNiIsImNvbXBhbnlfa2V5X3NjaGVtZSI6Im5sLmt2ayJ9.g8AV7d5YhmMDbc9cJOHEeUn8yacAlxxnGG0zj06E52P7Jai2MlOr40U7hsjBmyjqIczfzXlI5J-kQ-sHEbz2qUsLXRAMpkYHW3Fck53F4KE4IPKaZizrTMJSqH-V_zRRwgWbs51H8dHI6eaYY3uEy0MlQTOKN2tyWI1oLMYO80Ahnl35-UIf7WWFhD5Zk_rDhXR_tnfw1xBrZd1zM5lbB1UHqKOgDILcm_24DNKWsWx_j9lT9cfFgh16qSib6SjEaijxDYRz3W4tOnY7YMU6jNjCT8WJziqDaXaILOotHXEDoeFlALoIJYs9koLauyiNxAhD4tYUsydv-N4q1oiMaQ";

    public const string Example_MilkingVisit_Gea_20220621_Id1 = "8143fd73-9d28-48a3-8623-df0191c8ce96";
    public const string Example_MilkingVisit_Gea_20220621 = @"
	        {
		        ""eventType"": ""icarMilkingVisitEventResource"",
		        ""@self"": null,
		        ""meta"": {
			        ""source"": ""gea"",
			        ""sourceId"": ""8143fd73-9d28-48a3-8623-df0191c8ce96"",
			        ""modified"": ""2022-06-15T09:07:53.010293+00:00"",
			        ""created"": ""2022-06-15T09:07:52.791309+00:00"",
			        ""creator"": ""PROCESSCONTROL"",
			        ""validFrom"": null,
			        ""changeable"": null,
			        ""validTo"": null
		        },
		        ""id"": """ + Example_MilkingVisit_Gea_20220621_Id1 + @""",
		        ""animal"": {
			        ""identifierType"": ""icarAnimalIdentifierType"",
			        ""id"": ""528000123456789"",
			        ""scheme"": ""eu.animalId""
		        },
		        ""eventDateTime"": ""2022-06-15T09:01:32.869+00:00"",
		        ""location"": {
			        ""identifierType"": ""icarLocationIdentifierType"",
			        ""id"": ""00000001234567"",
			        ""scheme"": ""eu.farmId""
		        },
		        ""traitLabel"": null,
		        ""responsible"": null,
		        ""contemporaryGroup"": null,
		        ""milkingStartingDateTime"": ""2022-06-15T09:01:32.869+00:00"",
		        ""milkingDuration"": {
			        ""unitCode"": ""SEC"",
			        ""value"": 275
		        },
		        ""milkingVisitDuration"": {
			        ""unitCode"": ""SEC"",
			        ""value"": 439
		        },
		        ""milkingType"": ""Automated"",
		        ""milkingMilkWeight"": {
			        ""unitCode"": ""KGM"",
			        ""value"": 9.84
		        },
		        ""goodMilkWeight"": {
			        ""unitCode"": ""KGM"",
			        ""value"": 9.84
		        },
		        ""milkingComplete"": true,
		        ""milkingParlourUnit"": ""Boks "",
		        ""milkingBoxNumber"": ""3"",
		        ""milkingDeviceId"": ""3"",
		        ""measureDeviceId"": ""3"",
		        ""quarterMilkings"": null,
		        ""animalMilkingSample"": [],
		        ""milkCharacteristics"": [
			        {
				        ""characteristic"": ""AVGFLWR"",
				        ""value"": ""2.14"",
				        ""unit"": ""KGM"",
				        ""measuringDevice"": null
			        }
		        ]
	        }";
}

