using System;
using System.Collections.Generic;

namespace SecurityIntegration.Library
{
    public class DefectDojoModels
    {
        public DefectDojoModels()
        {
        }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ReqResp
    {
        public string additionalProp1 { get; set; }
        public string additionalProp2 { get; set; }
        public string additionalProp3 { get; set; }
    }

    public class RequestResponse
    {
        public List<ReqResp> req_resp { get; set; }
    }

    public class AcceptedRisk
    {
        public int id { get; set; }
        public string name { get; set; }
        public string recommendation { get; set; }
        public string recommendation_details { get; set; }
        public string decision { get; set; }
        public string decision_details { get; set; }
        public string accepted_by { get; set; }
        public string path { get; set; }
        public DateTime expiration_date { get; set; }
        public DateTime expiration_date_warned { get; set; }
        public DateTime expiration_date_handled { get; set; }
        public bool reactivate_expired { get; set; }
        public bool restart_sla_expired { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public int owner { get; set; }
        public List<int> accepted_findings { get; set; }
        public List<int> notes { get; set; }
    }

    public class FindingMeta
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class TestType
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class ProdType
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public ProdType prod_type { get; set; }
    }

    public class Engagement
    {
        public int id { get; set; }
        public string name { get; set; }
        public Product product { get; set; }
        public string branch_tag { get; set; }
        public string build_id { get; set; }
        public string commit_hash { get; set; }
        public string version { get; set; }
    }

    public class Environment
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Test
    {
        public int id { get; set; }
        public string title { get; set; }
        public TestType test_type { get; set; }
        public Engagement engagement { get; set; }
        public Environment environment { get; set; }
        public string branch_tag { get; set; }
        public string build_id { get; set; }
        public string commit_hash { get; set; }
        public string version { get; set; }
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class Jira
    {
        public int id { get; set; }
        public string url { get; set; }
        public string jira_id { get; set; }
        public string jira_key { get; set; }
        public DateTime jira_creation { get; set; }
        public DateTime jira_change { get; set; }
        public int jira_project { get; set; }
        public int finding { get; set; }
        public int engagement { get; set; }
        public int finding_group { get; set; }
    }

    public class RelatedFields
    {
        public Test test { get; set; }
        public Jira jira { get; set; }
    }

    public class JiraIssue
    {
        public int id { get; set; }
        public string url { get; set; }
        public string jira_id { get; set; }
        public string jira_key { get; set; }
        public DateTime jira_creation { get; set; }
        public DateTime jira_change { get; set; }
        public int jira_project { get; set; }
        public int finding { get; set; }
        public int engagement { get; set; }
        public int finding_group { get; set; }
    }

    public class FindingGroup
    {
        public int id { get; set; }
        public string name { get; set; }
        public int test { get; set; }
        public JiraIssue jira_issue { get; set; }
    }

    public class Author
    {
        public int id { get; set; }
        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }

    public class Editor
    {
        public int id { get; set; }
        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }

    public class CurrentEditor
    {
        public int id { get; set; }
        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }

    public class History
    {
        public int id { get; set; }
        public CurrentEditor current_editor { get; set; }
        public string data { get; set; }
        public DateTime time { get; set; }
        public int note_type { get; set; }
    }

    public class Note
    {
        public int id { get; set; }
        public Author author { get; set; }
        public Editor editor { get; set; }
        public List<History> history { get; set; }
        public string entry { get; set; }
        public DateTime date { get; set; }
        public bool @private { get; set; }
        public bool edited { get; set; }
        public DateTime edit_time { get; set; }
        public int note_type { get; set; }
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class FindingIssue
    {
        public int id { get; set; }
        public List<string> tags { get; set; }
        public RequestResponse request_response { get; set; }
        public List<AcceptedRisk> accepted_risks { get; set; }
        public bool push_to_jira { get; set; }
        public int age { get; set; }
        public int sla_days_remaining { get; set; }
        public List<FindingMeta> finding_meta { get; set; }
        public RelatedFields related_fields { get; set; }
        public DateTime jira_creation { get; set; }
        public DateTime jira_change { get; set; }
        public string display_status { get; set; }
        public List<FindingGroup> finding_groups { get; set; }
        public string title { get; set; }
        public string date { get; set; }
        public string sla_start_date { get; set; }
        public int cwe { get; set; }
        public string cve { get; set; }
        public string cvssv3 { get; set; }
        public int cvssv3_score { get; set; }
        public string url { get; set; }
        public string severity { get; set; }
        public string description { get; set; }
        public string mitigation { get; set; }
        public string impact { get; set; }
        public string steps_to_reproduce { get; set; }
        public string severity_justification { get; set; }
        public string references { get; set; }
        public bool active { get; set; }
        public bool verified { get; set; }
        public bool false_p { get; set; }
        public bool duplicate { get; set; }
        public bool out_of_scope { get; set; }
        public bool risk_accepted { get; set; }
        public bool under_review { get; set; }
        public DateTime last_status_update { get; set; }
        public bool under_defect_review { get; set; }
        public bool is_mitigated { get; set; }
        public int thread_id { get; set; }
        public DateTime mitigated { get; set; }
        public string numerical_severity { get; set; }
        public DateTime last_reviewed { get; set; }
        public string param { get; set; }
        public string payload { get; set; }
        public string hash_code { get; set; }
        public int line { get; set; }
        public string file_path { get; set; }
        public string component_name { get; set; }
        public string component_version { get; set; }
        public bool static_finding { get; set; }
        public bool dynamic_finding { get; set; }
        public DateTime created { get; set; }
        public int scanner_confidence { get; set; }
        public string unique_id_from_tool { get; set; }
        public string vuln_id_from_tool { get; set; }
        public string sast_source_object { get; set; }
        public string sast_sink_object { get; set; }
        public int sast_source_line { get; set; }
        public string sast_source_file_path { get; set; }
        public int nb_occurences { get; set; }
        public string publish_date { get; set; }
        public int test { get; set; }
        public int duplicate_finding { get; set; }
        public int review_requested_by { get; set; }
        public int defect_review_requested_by { get; set; }
        public int mitigated_by { get; set; }
        public int reporter { get; set; }
        public int last_reviewed_by { get; set; }
        public int sonarqube_issue { get; set; }
        public List<int> endpoints { get; set; }
        public List<int> endpoint_status { get; set; }
        public List<int> reviewers { get; set; }
        public List<Note> notes { get; set; }
        public List<int> files { get; set; }
        public List<int> found_by { get; set; }
    }

    public class AdditionalProp1
    {
        public int id { get; set; }
        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public List<string> tags { get; set; }
        public RequestResponse request_response { get; set; }
        public List<AcceptedRisk> accepted_risks { get; set; }
        public bool push_to_jira { get; set; }
        public int age { get; set; }
        public int sla_days_remaining { get; set; }
        public List<FindingMeta> finding_meta { get; set; }
        public RelatedFields related_fields { get; set; }
        public DateTime jira_creation { get; set; }
        public DateTime jira_change { get; set; }
        public string display_status { get; set; }
        public List<FindingGroup> finding_groups { get; set; }
        public string title { get; set; }
        public string date { get; set; }
        public string sla_start_date { get; set; }
        public int cwe { get; set; }
        public string cve { get; set; }
        public string cvssv3 { get; set; }
        public int cvssv3_score { get; set; }
        public string url { get; set; }
        public string severity { get; set; }
        public string description { get; set; }
        public string mitigation { get; set; }
        public string impact { get; set; }
        public string steps_to_reproduce { get; set; }
        public string severity_justification { get; set; }
        public string references { get; set; }
        public bool active { get; set; }
        public bool verified { get; set; }
        public bool false_p { get; set; }
        public bool duplicate { get; set; }
        public bool out_of_scope { get; set; }
        public bool risk_accepted { get; set; }
        public bool under_review { get; set; }
        public DateTime last_status_update { get; set; }
        public bool under_defect_review { get; set; }
        public bool is_mitigated { get; set; }
        public int thread_id { get; set; }
        public DateTime mitigated { get; set; }
        public string numerical_severity { get; set; }
        public DateTime last_reviewed { get; set; }
        public string param { get; set; }
        public string payload { get; set; }
        public string hash_code { get; set; }
        public int line { get; set; }
        public string file_path { get; set; }
        public string component_name { get; set; }
        public string component_version { get; set; }
        public bool static_finding { get; set; }
        public bool dynamic_finding { get; set; }
        public DateTime created { get; set; }
        public int scanner_confidence { get; set; }
        public string unique_id_from_tool { get; set; }
        public string vuln_id_from_tool { get; set; }
        public string sast_source_object { get; set; }
        public string sast_sink_object { get; set; }
        public int sast_source_line { get; set; }
        public string sast_source_file_path { get; set; }
        public int nb_occurences { get; set; }
        public string publish_date { get; set; }
        public int test { get; set; }
        public int duplicate_finding { get; set; }
        public int review_requested_by { get; set; }
        public int defect_review_requested_by { get; set; }
        public int mitigated_by { get; set; }
        public int reporter { get; set; }
        public int last_reviewed_by { get; set; }
        public int sonarqube_issue { get; set; }
        public List<int> endpoints { get; set; }
        public List<int> endpoint_status { get; set; }
        public List<int> reviewers { get; set; }
        public List<Note> notes { get; set; }
        public List<int> files { get; set; }
        public List<int> found_by { get; set; }
        public DateTime last_modified { get; set; }
        public DateTime mitigated_time { get; set; }
        public bool false_positive { get; set; }
        public int endpoint { get; set; }
        public int finding { get; set; }
        public string protocol { get; set; }
        public string userinfo { get; set; }
        public string host { get; set; }
        public int port { get; set; }
        public string path { get; set; }
        public string query { get; set; }
        public string fragment { get; set; }
        public int product { get; set; }
        public List<int> endpoint_params { get; set; }
        public string file { get; set; }
        public string name { get; set; }
        public JiraIssue jira_issue { get; set; }
        public bool static_tool { get; set; }
        public bool dynamic_tool { get; set; }
        public Author author { get; set; }
        public Editor editor { get; set; }
        public List<History> history { get; set; }
        public string entry { get; set; }
        public bool @private { get; set; }
        public bool edited { get; set; }
        public DateTime edit_time { get; set; }
        public int note_type { get; set; }
        public string recommendation { get; set; }
        public string recommendation_details { get; set; }
        public string decision { get; set; }
        public string decision_details { get; set; }
        public string accepted_by { get; set; }
        public DateTime expiration_date { get; set; }
        public DateTime expiration_date_warned { get; set; }
        public DateTime expiration_date_handled { get; set; }
        public bool reactivate_expired { get; set; }
        public bool restart_sla_expired { get; set; }
        public DateTime updated { get; set; }
        public int owner { get; set; }
        public List<int> accepted_findings { get; set; }
        public string key { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string test_type_name { get; set; }
        public string scan_type { get; set; }
        public DateTime target_start { get; set; }
        public DateTime target_end { get; set; }
        public string estimated_time { get; set; }
        public string actual_time { get; set; }
        public int percent_complete { get; set; }
        public string version { get; set; }
        public string build_id { get; set; }
        public string commit_hash { get; set; }
        public string branch_tag { get; set; }
        public int engagement { get; set; }
        public int lead { get; set; }
        public int test_type { get; set; }
        public int environment { get; set; }
        public int api_scan_configuration { get; set; }
        public List<TestImportFindingActionSet> test_import_finding_action_set { get; set; }
        public DateTime modified { get; set; }
        public ImportSettings import_settings { get; set; }
        public List<int> findings_affected { get; set; }
    }

    public class AdditionalProp2
    {
        public int id { get; set; }
        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public List<string> tags { get; set; }
        public RequestResponse request_response { get; set; }
        public List<AcceptedRisk> accepted_risks { get; set; }
        public bool push_to_jira { get; set; }
        public int age { get; set; }
        public int sla_days_remaining { get; set; }
        public List<FindingMeta> finding_meta { get; set; }
        public RelatedFields related_fields { get; set; }
        public DateTime jira_creation { get; set; }
        public DateTime jira_change { get; set; }
        public string display_status { get; set; }
        public List<FindingGroup> finding_groups { get; set; }
        public string title { get; set; }
        public string date { get; set; }
        public string sla_start_date { get; set; }
        public int cwe { get; set; }
        public string cve { get; set; }
        public string cvssv3 { get; set; }
        public int cvssv3_score { get; set; }
        public string url { get; set; }
        public string severity { get; set; }
        public string description { get; set; }
        public string mitigation { get; set; }
        public string impact { get; set; }
        public string steps_to_reproduce { get; set; }
        public string severity_justification { get; set; }
        public string references { get; set; }
        public bool active { get; set; }
        public bool verified { get; set; }
        public bool false_p { get; set; }
        public bool duplicate { get; set; }
        public bool out_of_scope { get; set; }
        public bool risk_accepted { get; set; }
        public bool under_review { get; set; }
        public DateTime last_status_update { get; set; }
        public bool under_defect_review { get; set; }
        public bool is_mitigated { get; set; }
        public int thread_id { get; set; }
        public DateTime mitigated { get; set; }
        public string numerical_severity { get; set; }
        public DateTime last_reviewed { get; set; }
        public string param { get; set; }
        public string payload { get; set; }
        public string hash_code { get; set; }
        public int line { get; set; }
        public string file_path { get; set; }
        public string component_name { get; set; }
        public string component_version { get; set; }
        public bool static_finding { get; set; }
        public bool dynamic_finding { get; set; }
        public DateTime created { get; set; }
        public int scanner_confidence { get; set; }
        public string unique_id_from_tool { get; set; }
        public string vuln_id_from_tool { get; set; }
        public string sast_source_object { get; set; }
        public string sast_sink_object { get; set; }
        public int sast_source_line { get; set; }
        public string sast_source_file_path { get; set; }
        public int nb_occurences { get; set; }
        public string publish_date { get; set; }
        public int test { get; set; }
        public int duplicate_finding { get; set; }
        public int review_requested_by { get; set; }
        public int defect_review_requested_by { get; set; }
        public int mitigated_by { get; set; }
        public int reporter { get; set; }
        public int last_reviewed_by { get; set; }
        public int sonarqube_issue { get; set; }
        public List<int> endpoints { get; set; }
        public List<int> endpoint_status { get; set; }
        public List<int> reviewers { get; set; }
        public List<Note> notes { get; set; }
        public List<int> files { get; set; }
        public List<int> found_by { get; set; }
        public DateTime last_modified { get; set; }
        public DateTime mitigated_time { get; set; }
        public bool false_positive { get; set; }
        public int endpoint { get; set; }
        public int finding { get; set; }
        public string protocol { get; set; }
        public string userinfo { get; set; }
        public string host { get; set; }
        public int port { get; set; }
        public string path { get; set; }
        public string query { get; set; }
        public string fragment { get; set; }
        public int product { get; set; }
        public List<int> endpoint_params { get; set; }
        public string file { get; set; }
        public string name { get; set; }
        public JiraIssue jira_issue { get; set; }
        public bool static_tool { get; set; }
        public bool dynamic_tool { get; set; }
        public Author author { get; set; }
        public Editor editor { get; set; }
        public List<History> history { get; set; }
        public string entry { get; set; }
        public bool @private { get; set; }
        public bool edited { get; set; }
        public DateTime edit_time { get; set; }
        public int note_type { get; set; }
        public string recommendation { get; set; }
        public string recommendation_details { get; set; }
        public string decision { get; set; }
        public string decision_details { get; set; }
        public string accepted_by { get; set; }
        public DateTime expiration_date { get; set; }
        public DateTime expiration_date_warned { get; set; }
        public DateTime expiration_date_handled { get; set; }
        public bool reactivate_expired { get; set; }
        public bool restart_sla_expired { get; set; }
        public DateTime updated { get; set; }
        public int owner { get; set; }
        public List<int> accepted_findings { get; set; }
        public string key { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string test_type_name { get; set; }
        public string scan_type { get; set; }
        public DateTime target_start { get; set; }
        public DateTime target_end { get; set; }
        public string estimated_time { get; set; }
        public string actual_time { get; set; }
        public int percent_complete { get; set; }
        public string version { get; set; }
        public string build_id { get; set; }
        public string commit_hash { get; set; }
        public string branch_tag { get; set; }
        public int engagement { get; set; }
        public int lead { get; set; }
        public int test_type { get; set; }
        public int environment { get; set; }
        public int api_scan_configuration { get; set; }
        public List<TestImportFindingActionSet> test_import_finding_action_set { get; set; }
        public DateTime modified { get; set; }
        public ImportSettings import_settings { get; set; }
        public List<int> findings_affected { get; set; }
    }

    public class AdditionalProp3
    {
        public int id { get; set; }
        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public List<string> tags { get; set; }
        public RequestResponse request_response { get; set; }
        public List<AcceptedRisk> accepted_risks { get; set; }
        public bool push_to_jira { get; set; }
        public int age { get; set; }
        public int sla_days_remaining { get; set; }
        public List<FindingMeta> finding_meta { get; set; }
        public RelatedFields related_fields { get; set; }
        public DateTime jira_creation { get; set; }
        public DateTime jira_change { get; set; }
        public string display_status { get; set; }
        public List<FindingGroup> finding_groups { get; set; }
        public string title { get; set; }
        public string date { get; set; }
        public string sla_start_date { get; set; }
        public int cwe { get; set; }
        public string cve { get; set; }
        public string cvssv3 { get; set; }
        public int cvssv3_score { get; set; }
        public string url { get; set; }
        public string severity { get; set; }
        public string description { get; set; }
        public string mitigation { get; set; }
        public string impact { get; set; }
        public string steps_to_reproduce { get; set; }
        public string severity_justification { get; set; }
        public string references { get; set; }
        public bool active { get; set; }
        public bool verified { get; set; }
        public bool false_p { get; set; }
        public bool duplicate { get; set; }
        public bool out_of_scope { get; set; }
        public bool risk_accepted { get; set; }
        public bool under_review { get; set; }
        public DateTime last_status_update { get; set; }
        public bool under_defect_review { get; set; }
        public bool is_mitigated { get; set; }
        public int thread_id { get; set; }
        public DateTime mitigated { get; set; }
        public string numerical_severity { get; set; }
        public DateTime last_reviewed { get; set; }
        public string param { get; set; }
        public string payload { get; set; }
        public string hash_code { get; set; }
        public int line { get; set; }
        public string file_path { get; set; }
        public string component_name { get; set; }
        public string component_version { get; set; }
        public bool static_finding { get; set; }
        public bool dynamic_finding { get; set; }
        public DateTime created { get; set; }
        public int scanner_confidence { get; set; }
        public string unique_id_from_tool { get; set; }
        public string vuln_id_from_tool { get; set; }
        public string sast_source_object { get; set; }
        public string sast_sink_object { get; set; }
        public int sast_source_line { get; set; }
        public string sast_source_file_path { get; set; }
        public int nb_occurences { get; set; }
        public string publish_date { get; set; }
        public int test { get; set; }
        public int duplicate_finding { get; set; }
        public int review_requested_by { get; set; }
        public int defect_review_requested_by { get; set; }
        public int mitigated_by { get; set; }
        public int reporter { get; set; }
        public int last_reviewed_by { get; set; }
        public int sonarqube_issue { get; set; }
        public List<int> endpoints { get; set; }
        public List<int> endpoint_status { get; set; }
        public List<int> reviewers { get; set; }
        public List<Note> notes { get; set; }
        public List<int> files { get; set; }
        public List<int> found_by { get; set; }
        public DateTime last_modified { get; set; }
        public DateTime mitigated_time { get; set; }
        public bool false_positive { get; set; }
        public int endpoint { get; set; }
        public int finding { get; set; }
        public string protocol { get; set; }
        public string userinfo { get; set; }
        public string host { get; set; }
        public int port { get; set; }
        public string path { get; set; }
        public string query { get; set; }
        public string fragment { get; set; }
        public int product { get; set; }
        public List<int> endpoint_params { get; set; }
        public string file { get; set; }
        public string name { get; set; }
        public JiraIssue jira_issue { get; set; }
        public bool static_tool { get; set; }
        public bool dynamic_tool { get; set; }
        public Author author { get; set; }
        public Editor editor { get; set; }
        public List<History> history { get; set; }
        public string entry { get; set; }
        public bool @private { get; set; }
        public bool edited { get; set; }
        public DateTime edit_time { get; set; }
        public int note_type { get; set; }
        public string recommendation { get; set; }
        public string recommendation_details { get; set; }
        public string decision { get; set; }
        public string decision_details { get; set; }
        public string accepted_by { get; set; }
        public DateTime expiration_date { get; set; }
        public DateTime expiration_date_warned { get; set; }
        public DateTime expiration_date_handled { get; set; }
        public bool reactivate_expired { get; set; }
        public bool restart_sla_expired { get; set; }
        public DateTime updated { get; set; }
        public int owner { get; set; }
        public List<int> accepted_findings { get; set; }
        public string key { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string test_type_name { get; set; }
        public string scan_type { get; set; }
        public DateTime target_start { get; set; }
        public DateTime target_end { get; set; }
        public string estimated_time { get; set; }
        public string actual_time { get; set; }
        public int percent_complete { get; set; }
        public string version { get; set; }
        public string build_id { get; set; }
        public string commit_hash { get; set; }
        public string branch_tag { get; set; }
        public int engagement { get; set; }
        public int lead { get; set; }
        public int test_type { get; set; }
        public int environment { get; set; }
        public int api_scan_configuration { get; set; }
        public List<TestImportFindingActionSet> test_import_finding_action_set { get; set; }
        public DateTime modified { get; set; }
        public ImportSettings import_settings { get; set; }
        public List<int> findings_affected { get; set; }
    }

    public class DefectReviewRequestedBy
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class DuplicateFinding
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class EndpointStatus
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class Endpoints
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class Files
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
        public int id { get; set; }
        public string file { get; set; }
        public string title { get; set; }
    }

    public class FindingGroupSet
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class FoundBy
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class LastReviewedBy
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class MitigatedBy
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class Reporter
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class ReviewRequestedBy
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class Reviewers
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class RiskAcceptanceSet
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class SonarqubeIssue
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class TestImportFindingActionSet
    {
        public int id { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public string action { get; set; }
        public int test_import { get; set; }
        public int finding { get; set; }
    }

    public class ImportSettings
    {
    }

    public class TestImportSet
    {
        public AdditionalProp1 additionalProp1 { get; set; }
        public AdditionalProp2 additionalProp2 { get; set; }
        public AdditionalProp3 additionalProp3 { get; set; }
    }

    public class Prefetch
    {
        public DefectReviewRequestedBy defect_review_requested_by { get; set; }
        public DuplicateFinding duplicate_finding { get; set; }
        public EndpointStatus endpoint_status { get; set; }
        public Endpoints endpoints { get; set; }
        public Files files { get; set; }
        public FindingGroupSet finding_group_set { get; set; }
        public FoundBy found_by { get; set; }
        public LastReviewedBy last_reviewed_by { get; set; }
        public MitigatedBy mitigated_by { get; set; }
        public List<int> notes { get; set; }
        public Reporter reporter { get; set; }
        public ReviewRequestedBy review_requested_by { get; set; }
        public Reviewers reviewers { get; set; }
        public RiskAcceptanceSet risk_acceptance_set { get; set; }
        public SonarqubeIssue sonarqube_issue { get; set; }
        public Test test { get; set; }
        public TestImportSet test_import_set { get; set; }
    }
        

    public class Root
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<FindingIssue> results { get; set; }
        public Prefetch prefetch { get; set; }
    }


}
