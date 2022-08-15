internal class TestData
{
    public const string BearerToken = "eyJhbGciOiJSUzI1NiIsInR5cCIgOiAiSldUIiwia2lkIiA6ICJtQVlSQ2pIcERiUUUxRm1nVFVDdnA2Z0RKM2gzQlZmZEVUeVpCQWR1Sk44In0.eyJleHAiOjE2NjA1NjUwMDUsImlhdCI6MTY2MDU2MzIwNSwianRpIjoiZjYzMmJiZTEtOTBkZi00OWE4LTlhZjAtMjdmMzQzNTFmYmMwIiwiaXNzIjoiaHR0cHM6Ly90ZXN0LmpvaW4tZGF0YS5uZXQvYXV0aC9yZWFsbXMvZGF0YWh1YiIsImF1ZCI6WyJmYXJtZXItcmVtIiwiYWNjb3VudCJdLCJzdWIiOiJiYTU4ZmVlZC01ZDFlLTRlYmMtYTAwOS0zZGJkNGU5YzRhZmUiLCJ0eXAiOiJCZWFyZXIiLCJhenAiOiJmYXJtZXItcmVtIiwicmVzb3VyY2VfYWNjZXNzIjp7ImFjY291bnQiOnsicm9sZXMiOlsibWFuYWdlLWFjY291bnQiLCJtYW5hZ2UtYWNjb3VudC1saW5rcyIsInZpZXctcHJvZmlsZSJdfX0sInNjb3BlIjoicHJvZmlsZSBlbWFpbCBEYXRhc291cmNlX1Byb3ZpZGVycyBBcHBsaWNhdGlvbl9kZXZlbG9wZXJzIiwiYXBwbGljYXRpb25fY29tcGFueV9rZXlfdmFsdWUiOiI2NTkzMTA0MSIsImNsaWVudEhvc3QiOiIxMC4yNDQuMS4xIiwiY2xpZW50SWQiOiJmYXJtZXItcmVtIiwiZW1haWxfdmVyaWZpZWQiOmZhbHNlLCJhcHBsaWNhdGlvbl9jb21wYW55X2ZpbHRlciI6dHJ1ZSwiYXBwbGljYXRpb25fY29tcGFueV9rZXlfc2NoZW1lIjoibmwua3ZrIiwicHJlZmVycmVkX3VzZXJuYW1lIjoic2VydmljZS1hY2NvdW50LWZhcm1lci1yZW0iLCJlbWJlZGRpbmciOnRydWUsImNvbXBhbnlfa2V5X3ZhbHVlIjoiNjU4NzU4NDIiLCJjbGllbnRBZGRyZXNzIjoiMTAuMjQ0LjEuMSIsImNvbXBhbnlfa2V5X3NjaGVtZSI6Im5sLmt2ayJ9.YedW82OiU4hR_5ybhrAziLQnmIJNhZctvm0jcIHmV-BF2Qyw9pDhA-4sTjycj1g81MU-2f5ZuXtpcgaS_aFCIv6I_aEruXQRO9uP9tLVaAo9eS5IISmAQmVIYOCXkXbcVu1jGPxBjpP7adYKkZHkT8y44LyxPR_kKip8BuO5U30wxn8zXCjZG_BEdI5fTJZcQYyMY3RxBzW_m2xeq0enlkaij_KCdlgV-udDFI6bMY87RohtwWX9rpkDzGSwl64bsRLqQ0neYFkJSxBs52Zt7KaOCezNca61UfM_aI-DuUYbWCtTOYAxt9kRyvw7SxSZJyfw0MRtdh5Wc-7p9Mg8UQ";

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

