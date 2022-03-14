using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SecurityIntegration.Library
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Paging
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public int total { get; set; }
    }

    public class Component
    {
        public string key { get; set; }
        public string name { get; set; }
        public string qualifier { get; set; }
        public string visibility { get; set; }
        public DateTime lastAnalysisDate { get; set; }
        public string revision { get; set; }
    }

    public class SonarQubeRootProject
    {
        public Paging paging { get; set; }
        public List<Component> components { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Comment
    {
        public string key { get; set; }
        public string login { get; set; }
        public string htmlText { get; set; }
        public string markdown { get; set; }
        public bool updatable { get; set; }
        public DateTime createdAt { get; set; }
    }

    public class Attr
    {
        [JsonProperty("jira-issue-key")]
        public string JiraIssueKey { get; set; }
    }

    public class TextRange
    {
        public int startLine { get; set; }
        public int endLine { get; set; }
        public int startOffset { get; set; }
        public int endOffset { get; set; }
    }

    public class Location
    {
        public TextRange textRange { get; set; }
        public string msg { get; set; }
    }

    public class Flow
    {
        public List<Location> locations { get; set; }
    }

    public class SonarQubeIssue
    {
        public string key { get; set; }
        public string component { get; set; }
        public string project { get; set; }
        public string rule { get; set; }
        public string status { get; set; }
        public string resolution { get; set; }
        public string severity { get; set; }
        public string message { get; set; }
        public int line { get; set; }
        public string hash { get; set; }
        public string author { get; set; }
        public string effort { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime updateDate { get; set; }
        public List<string> tags { get; set; }
        public string type { get; set; }
        public List<Comment> comments { get; set; }
        public Attr attr { get; set; }
        public List<string> transitions { get; set; }
        public List<string> actions { get; set; }
        public TextRange textRange { get; set; }
        public List<Flow> flows { get; set; }
        public bool quickFixAvailable { get; set; }
    }

    public class SonarQubeRootIssue
    {
        public Paging paging { get; set; }
        public List<SonarQubeIssue> issues { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Param
    {
        public string key { get; set; }
        public string htmlDesc { get; set; }
        public string defaultValue { get; set; }
        public string type { get; set; }
    }

    public class Rule
    {
        public string key { get; set; }
        public string repo { get; set; }
        public string name { get; set; }
        public DateTime createdAt { get; set; }
        public string htmlDesc { get; set; }
        public string mdDesc { get; set; }
        public string severity { get; set; }
        public string status { get; set; }
        public bool isTemplate { get; set; }
        public List<object> tags { get; set; }
        public List<string> sysTags { get; set; }
        public string lang { get; set; }
        public string langName { get; set; }
        public List<Param> @params { get; set; }
        public string defaultDebtRemFnType { get; set; }
        public string defaultDebtRemFnCoeff { get; set; }
        public string defaultDebtRemFnOffset { get; set; }
        public string effortToFixDescription { get; set; }
        public bool debtOverloaded { get; set; }
        public string debtRemFnType { get; set; }
        public string debtRemFnCoeff { get; set; }
        public string debtRemFnOffset { get; set; }
        public string type { get; set; }
        public string defaultRemFnType { get; set; }
        public string defaultRemFnGapMultiplier { get; set; }
        public string defaultRemFnBaseEffort { get; set; }
        public string remFnType { get; set; }
        public string remFnGapMultiplier { get; set; }
        public string remFnBaseEffort { get; set; }
        public bool remFnOverloaded { get; set; }
        public string gapDescription { get; set; }
        public string scope { get; set; }
        public bool isExternal { get; set; }
    }

    public class SonarQubeRootRule
    {
        public int total { get; set; }
        public int p { get; set; }
        public int ps { get; set; }
        public List<Rule> rules { get; set; }
    }




}
