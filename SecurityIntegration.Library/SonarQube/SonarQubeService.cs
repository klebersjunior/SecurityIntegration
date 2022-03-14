using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace SecurityIntegration.Library
{
    public class SonarQubeService
    {
        private IConfigurationRoot configuration;
        private SonarQubeDataService sonarQubeDataService;


        public SonarQubeService(IConfigurationRoot configuration)
        {
            this.configuration = configuration;
            sonarQubeDataService = new SonarQubeDataService(configuration.GetSection("SonarUrl").Value, configuration.GetSection("SonarKey").Value.ToSecureString());
        }

        public SonarQubeRootProject GetProject(string projectName)
        {
            var projects = sonarQubeDataService.GetApiAsync($"api/projects/search?projects={projectName}").GetAwaiter().GetResult();

            SonarQubeRootProject sonarQubeRoot = JsonConvert.DeserializeObject<SonarQubeRootProject>(projects);



            return sonarQubeRoot;
        }

        public List<SourceProjectInfo> GetProjects()
        {
            var projects = sonarQubeDataService.GetApiAsync("api/projects/search").GetAwaiter().GetResult();

            SonarQubeRootProject sonarQubeRoot = JsonConvert.DeserializeObject<SonarQubeRootProject>(projects);

            List<SourceProjectInfo> sourceProjectInfos = new List<SourceProjectInfo>();
            foreach (var item in sonarQubeRoot.components)
            {
                sourceProjectInfos.Add(new SourceProjectInfo
                {
                    Id = item.key,
                    ProjectName = item.name
                });
            }

            return sourceProjectInfos;
        }

        

        public List<FindingIssue> GetFindings(SourceProjectInfo sourceProject)
        {
            var issues = sonarQubeDataService.GetApiAsync($"api/issues/search?componentKeys={sourceProject}").GetAwaiter().GetResult();

            SonarQubeRootIssue sonarQubeRootIssue = JsonConvert.DeserializeObject<SonarQubeRootIssue>(issues);

            List<FindingIssue> findingIssues = new List<FindingIssue>();

            foreach (var item in sonarQubeRootIssue.issues)
            {
                FindingIssue findingIssue = new FindingIssue();

                var rule = GetRule(item.rule).rules.FirstOrDefault();

                findingIssue.severity = item.severity;
                findingIssue.title = rule.name;
                findingIssue.description = rule.htmlDesc;
                findingIssue.line = item.line;
                findingIssue.sast_source_file_path = item.component;
                findingIssue.mitigation = item.resolution;
                findingIssue.impact = rule.htmlDesc;
                findingIssues.Add(findingIssue);
            }

            return findingIssues;
        }

        public SonarQubeRootRule GetRule(string ruleKey)
        {
            var projects = sonarQubeDataService.GetApiAsync($"api/rules/search?rule_key={ruleKey}").GetAwaiter().GetResult();

            SonarQubeRootRule sonarQubeRoot = JsonConvert.DeserializeObject<SonarQubeRootRule>(projects);


            return sonarQubeRoot;
        }
    }
}
