using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Microsoft.Extensions.Configuration;

namespace SecurityIntegration.Library
{
    public class GoogleSheet
    {
        public IConfigurationRoot configuration;
        private string SpreadsheetId { get; set; }
        public GoogleSheet(IConfigurationRoot _configuration)
        {
            configuration = _configuration;
            SpreadsheetId = configuration.GetSection("SpreadsheetId").Value;
        }

        private static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        
        private const string GoogleCredentialsFileName = "google-credentials.json";

        private SheetsService GetSheetsService()
        {
            using (var stream = new FileStream(GoogleCredentialsFileName, FileMode.Open, FileAccess.Read))
            {
                var serviceInitializer = new BaseClientService.Initializer
                {
                    HttpClientInitializer = GoogleCredential.FromStream(stream).CreateScoped(Scopes)
                };
                return new SheetsService(serviceInitializer);
            }
        }

        public List<GoogleSheetMappingClass> GetInfo(string sheet)
        {
            List<GoogleSheetMappingClass> googleSheetMappingClasses = new List<GoogleSheetMappingClass>();
            var range = $"{sheet}!A:H";
            var data = GetSheetsService().Spreadsheets.Values.Get(SpreadsheetId,range).Execute().Values;

            foreach (var row in data.Skip(1))
            {
                GoogleSheetMappingClass googleSheetMappingClass = new GoogleSheetMappingClass();
                googleSheetMappingClass.SourceProjectName = GetValue(row,0);
                googleSheetMappingClass.SourceUrlPattern = GetValue(row, 1);
                googleSheetMappingClass.DefectDojoProjectName = GetValue(row, 2);
                googleSheetMappingClass.Squad = GetValue(row, 3);
                googleSheetMappingClass.Gerencia = GetValue(row, 4);
                googleSheetMappingClass.Vertical = GetValue(row, 5);
                googleSheetMappingClass.Diretoria = GetValue(row, 6);
                googleSheetMappingClasses.Add(googleSheetMappingClass);
                
            }

            return googleSheetMappingClasses;
        }

        private string GetValue(IList<object> row, int index)
        {
            if (row.Count - 1 > index)
            {
                try
                {
                    return row[index].ToString();
                }
                catch
                {
                    return null;
                }
            }
            else
                return string.Empty;
        }

        public void AddNewLine(GoogleSheetMappingClass item)
        {
            
        }
    }
}
