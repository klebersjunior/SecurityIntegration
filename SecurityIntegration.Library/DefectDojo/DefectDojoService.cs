using System;
using Microsoft.Extensions.Configuration;

namespace SecurityIntegration.Library
{
    public class DefectDojoService
    {
        private IConfigurationRoot configuration;
        private DefectDojoDataService defectDojoDataService;




        public DefectDojoService(IConfigurationRoot configuration)
        {
            this.configuration = configuration;
            defectDojoDataService = new DefectDojoDataService(configuration.GetSection("DefectDojoUrl").Value, configuration.GetSection("DefectDojoKey").Value.ToSecureString(), configuration.GetSection("DefectDojoKey").Value.ToSecureString());

        }

        public bool CreateFinding(GoogleSheetMappingClass mapping, FindingIssue issue)
        {
            throw new NotImplementedException();
        }

        public Product GetDefectDojoProject(GoogleSheetMappingClass item)
        {
            var project = defectDojoDataService.GetApiAsync(DefectDojotApiVersion.v2, $"/api/v2/products/?name={item.DefectDojoProjectName}").GetAwaiter().GetResult();

            //If Project not exists create project


            //return project
            return new Product();
        }

        public Engagement CreateEngagement(GoogleSheetMappingClass item, Product product)
        {
            throw new NotImplementedException();
        }

        public Test CreateTest(GoogleSheetMappingClass item, Product product, Engagement engagement)
        {
            throw new NotImplementedException();
        }
    }
}
