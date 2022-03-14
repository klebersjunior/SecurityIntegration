using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;
using SecurityIntegration.Library;

namespace SecurityIntegration.SonarDefectDojo
{
    
    class Program
    {
        public static IConfigurationRoot configuration;



        static void Main(string[] args)
		{
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true); ;
            configuration = builder.Build();

            //Read Projects in Source
            List<SourceProjectInfo> sourceProjects = new List<SourceProjectInfo>();
            SonarQubeService sonarQubeService = new SonarQubeService(configuration);
            sourceProjects = sonarQubeService.GetProjects();

            //Read Issues in Source
            List<FindingIssue> findings = new List<FindingIssue>();
            foreach (var sourceProject in sourceProjects)
            {
                findings.AddRange(sonarQubeService.GetFindings(sourceProject));
            }
            

            //Read Mapping
            GoogleSheet googleSheet = new GoogleSheet(configuration);
            List< GoogleSheetMappingClass> currentProjects = googleSheet.GetInfo("Sonar");


            //Add New Projects
            List<GoogleSheetMappingClass> newProjects = new List<GoogleSheetMappingClass>();
            List<GoogleSheetMappingClass> integratedProjects = new List<GoogleSheetMappingClass>();
            foreach (var item in sourceProjects)
            {
                if (currentProjects.FirstOrDefault(x => x.SourceProjectName == item.ProjectName
                    && !string.IsNullOrEmpty(x.DefectDojoProjectName)
                    && !string.IsNullOrEmpty(x.Squad)
                    && !string.IsNullOrEmpty(x.Gerencia)
                    && !string.IsNullOrEmpty(x.Vertical)
                    && !string.IsNullOrEmpty(x.Diretoria)
                    ) == null)
                            newProjects.Add(new GoogleSheetMappingClass
                            {
                                SourceProjectName = item.ProjectName
                            });
                else {
                    integratedProjects.Add(currentProjects.FirstOrDefault(x => x.SourceProjectName == item.ProjectName));
                }
            }

            //Create In Sheet
            foreach (var item in newProjects)
            {
                //Check Exists but not complete information
                if (currentProjects.FirstOrDefault(x => x.SourceProjectName == item.SourceProjectName) == null)
                {
                    //Project in Sheet
                    googleSheet.AddNewLine(item);
                }
            }


            DefectDojoService defectDojoService = new DefectDojoService(configuration);
            //Integrate Projects With Defect Dojo
            foreach (var item in integratedProjects)
            {
                //Check Project Exists in DefectDojo
                Product product = defectDojoService.GetDefectDojoProject(item);

                if (findings.First(x => x.related_fields.test.engagement.product.name == product.name) != null)
                {
                    //Create Engagement if Issues > 0
                    Engagement engagement = defectDojoService.CreateEngagement(item, product);

                    //Create Test if Issues > 0
                    Test test = defectDojoService.CreateTest(item, product, engagement);
                    item.product = product;
                    item.engagement = engagement;
                    item.test = test;

                    //Create Findings
                    foreach (var finding in findings.Where(x => x.related_fields.test.engagement.product.name == product.name))
                    {
                        bool result = defectDojoService.CreateFinding(item, finding);
                    }
                }
            }
        }
    }
}
