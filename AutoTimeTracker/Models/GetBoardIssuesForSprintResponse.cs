using System.Text.Json.Serialization;

namespace AutoTimeTracker.Models
{
    public class GetBoardIssuesForSprintResponse
    {
        [JsonPropertyName("expand")]
        public string expand { get; set; }

        [JsonPropertyName("startAt")]
        public int startAt { get; set; }

        [JsonPropertyName("maxResults")]
        public int maxResults { get; set; }

        [JsonPropertyName("total")]
        public int total { get; set; }

        [JsonPropertyName("issues")]
        public Issue[] issues { get; set; }

        public class Issue
        {
            [JsonPropertyName("expand")]
            public string expand { get; set; }

            [JsonPropertyName("id")]
            public string id { get; set; }

            [JsonPropertyName("self")]
            public string self { get; set; }

            [JsonPropertyName("key")]
            public string key { get; set; }

            [JsonPropertyName("fields")]
            public Fields fields { get; set; }
        }

        public class Fields
        {
            [JsonPropertyName("statuscategorychangedate")]
            public DateTime statuscategorychangedate { get; set; }

            [JsonPropertyName("issuetype")]
            public IssueType issuetype { get; set; }

            [JsonPropertyName("timespent")]
            public object timespent { get; set; }

            [JsonPropertyName("sprint")]
            public Sprint sprint { get; set; }

            [JsonPropertyName("customfield_10030")]
            public object customfield_10030 { get; set; }

            [JsonPropertyName("project")]
            public Project project { get; set; }

            [JsonPropertyName("customfield_10031")]
            public object customfield_10031 { get; set; }

            [JsonPropertyName("customfield_10032")]
            public object[] customfield_10032 { get; set; }

            [JsonPropertyName("customfield_10033")]
            public object customfield_10033 { get; set; }

            [JsonPropertyName("fixVersions")]
            public object[] fixVersions { get; set; }

            [JsonPropertyName("aggregatetimespent")]
            public object aggregatetimespent { get; set; }

            [JsonPropertyName("customfield_10034")]
            public object customfield_10034 { get; set; }

            [JsonPropertyName("customfield_10035")]
            public object customfield_10035 { get; set; }

            [JsonPropertyName("resolution")]
            public object resolution { get; set; }

            [JsonPropertyName("customfield_10036")]
            public object customfield_10036 { get; set; }

            [JsonPropertyName("customfield_10037")]
            public object customfield_10037 { get; set; }

            [JsonPropertyName("customfield_10027")]
            public object customfield_10027 { get; set; }

            [JsonPropertyName("customfield_10028")]
            public object customfield_10028 { get; set; }

            [JsonPropertyName("customfield_10029")]
            public object customfield_10029 { get; set; }

            [JsonPropertyName("resolutiondate")]
            public object resolutiondate { get; set; }

            [JsonPropertyName("workratio")]
            public int workratio { get; set; }

            [JsonPropertyName("issuerestriction")]
            public IssueRestriction issuerestriction { get; set; }

            [JsonPropertyName("lastViewed")]
            public DateTime? lastViewed { get; set; }

            [JsonPropertyName("watches")]
            public Watches watches { get; set; }

            [JsonPropertyName("created")]
            public DateTime created { get; set; }

            [JsonPropertyName("customfield_10020")]
            public Customfield_10020[] customfield_10020 { get; set; }

            [JsonPropertyName("customfield_10021")]
            public object customfield_10021 { get; set; }

            [JsonPropertyName("epic")]
            public object epic { get; set; }

            [JsonPropertyName("customfield_10022")]
            public object customfield_10022 { get; set; }

            [JsonPropertyName("priority")]
            public Priority priority { get; set; }

            [JsonPropertyName("customfield_10023")]
            public object customfield_10023 { get; set; }

            [JsonPropertyName("customfield_10024")]
            public object customfield_10024 { get; set; }

            [JsonPropertyName("customfield_10025")]
            public object customfield_10025 { get; set; }

            [JsonPropertyName("labels")]
            public string[] labels { get; set; }

            [JsonPropertyName("customfield_10026")]
            public object customfield_10026 { get; set; }

            [JsonPropertyName("customfield_10016")]
            public float customfield_10016 { get; set; }

            [JsonPropertyName("customfield_10017")]
            public object customfield_10017 { get; set; }

            [JsonPropertyName("customfield_10018")]
            public Customfield_10018 customfield_10018 { get; set; }

            [JsonPropertyName("customfield_10019")]
            public string customfield_10019 { get; set; }

            [JsonPropertyName("aggregatetimeoriginalestimate")]
            public object aggregatetimeoriginalestimate { get; set; }

            [JsonPropertyName("timeestimate")]
            public object timeestimate { get; set; }

            [JsonPropertyName("versions")]
            public object[] versions { get; set; }

            [JsonPropertyName("issuelinks")]
            public object[] issuelinks { get; set; }

            [JsonPropertyName("assignee")]
            public Assignee assignee { get; set; }

            [JsonPropertyName("updated")]
            public DateTime updated { get; set; }

            [JsonPropertyName("status")]
            public Status status { get; set; }

            [JsonPropertyName("components")]
            public object[] components { get; set; }

            [JsonPropertyName("timeoriginalestimate")]
            public object timeoriginalestimate { get; set; }

            [JsonPropertyName("description")]
            public object description { get; set; }

            [JsonPropertyName("customfield_10010")]
            public object customfield_10010 { get; set; }

            [JsonPropertyName("customfield_10014")]
            public object customfield_10014 { get; set; }

            [JsonPropertyName("customfield_10015")]
            public object customfield_10015 { get; set; }

            [JsonPropertyName("timeTracking")]
            public TimeTracking timetracking { get; set; }

            [JsonPropertyName("customfield_10005")]
            public object customfield_10005 { get; set; }

            [JsonPropertyName("customfield_10006")]
            public object customfield_10006 { get; set; }

            [JsonPropertyName("customfield_10007")]
            public object customfield_10007 { get; set; }

            [JsonPropertyName("security")]
            public object security { get; set; }

            [JsonPropertyName("customfield_10008")]
            public object customfield_10008 { get; set; }

            [JsonPropertyName("aggregatetimeestimate")]
            public object aggregatetimeestimate { get; set; }

            [JsonPropertyName("attachment")]
            public object[] attachment { get; set; }

            [JsonPropertyName("customfield_10009")]
            public object customfield_10009 { get; set; }

            [JsonPropertyName("flagged")]
            public bool flagged { get; set; }

            [JsonPropertyName("summary")]
            public string summary { get; set; }

            [JsonPropertyName("creator")]
            public Creator creator { get; set; }

            [JsonPropertyName("subtasks")]
            public object[] subtasks { get; set; }

            [JsonPropertyName("customfield_10040")]
            public object customfield_10040 { get; set; }

            [JsonPropertyName("customfield_10042")]
            public object customfield_10042 { get; set; }

            [JsonPropertyName("reporter")]
            public Reporter reporter { get; set; }

            [JsonPropertyName("customfield_10043")]
            public object customfield_10043 { get; set; }

            [JsonPropertyName("customfield_10044")]
            public object customfield_10044 { get; set; }

            [JsonPropertyName("customfield_10000")]
            public string customfield_10000 { get; set; }

            [JsonPropertyName("aggregateprogress")]
            public AggregateProgress aggregateprogress { get; set; }

            [JsonPropertyName("customfield_10045")]
            public object customfield_10045 { get; set; }

            [JsonPropertyName("customfield_10001")]
            public object customfield_10001 { get; set; }

            [JsonPropertyName("customfield_10002")]
            public object customfield_10002 { get; set; }

            [JsonPropertyName("customfield_10003")]
            public object customfield_10003 { get; set; }

            [JsonPropertyName("customfield_10004")]
            public object customfield_10004 { get; set; }

            [JsonPropertyName("customfield_10038")]
            public object customfield_10038 { get; set; }

            [JsonPropertyName("customfield_10039")]
            public object customfield_10039 { get; set; }

            [JsonPropertyName("environment")]
            public object environment { get; set; }

            [JsonPropertyName("duedate")]
            public object duedate { get; set; }

            [JsonPropertyName("progress")]
            public Progress progress { get; set; }

            [JsonPropertyName("votes")]
            public Votes votes { get; set; }

            [JsonPropertyName("comment")]
            public Comment comment { get; set; }

            [JsonPropertyName("worklog")]
            public Worklog worklog { get; set; }
        }

        public class IssueType
        {
            [JsonPropertyName("self")]
            public string self { get; set; }

            [JsonPropertyName("id")]
            public string id { get; set; }

            [JsonPropertyName("description")]
            public string description { get; set; }

            [JsonPropertyName("iconUrl")]
            public string iconUrl { get; set; }

            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("subtask")]
            public bool subtask { get; set; }

            [JsonPropertyName("avatarId")]
            public int avatarId { get; set; }

            [JsonPropertyName("entityId")]
            public string entityId { get; set; }

            [JsonPropertyName("hierarchyLevel")]
            public int hierarchyLevel { get; set; }
        }

        public class Sprint
        {
            [JsonPropertyName("id")]
            public int id { get; set; }

            [JsonPropertyName("self")]
            public string self { get; set; }

            [JsonPropertyName("state")]
            public string state { get; set; }

            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("startDate")]
            public DateTime startDate { get; set; }

            [JsonPropertyName("endDate")]
            public DateTime endDate { get; set; }

            [JsonPropertyName("createdDate")]
            public DateTime createdDate { get; set; }

            [JsonPropertyName("originBoardId")]
            public int originBoardId { get; set; }

            [JsonPropertyName("goal")]
            public string goal { get; set; }
        }

        public class Project
        {
            [JsonPropertyName("self")]
            public string self { get; set; }

            [JsonPropertyName("id")]
            public string id { get; set; }

            [JsonPropertyName("key")]
            public string key { get; set; }

            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("projectTypeKey")]
            public string projectTypeKey { get; set; }

            [JsonPropertyName("simplified")]
            public bool simplified { get; set; }

            [JsonPropertyName("avatarUrls")]
            public AvatarUrls avatarUrls { get; set; }
        }

        public class AvatarUrls
        {
            [JsonPropertyName("_48x48")]
            public string _48x48 { get; set; }

            [JsonPropertyName("_24x24")]
            public string _24x24 { get; set; }

            [JsonPropertyName("_16x16")]
            public string _16x16 { get; set; }

            [JsonPropertyName("_32x32")]
            public string _32x32 { get; set; }
        }

        public class IssueRestriction
        {
            [JsonPropertyName("issuerestrictions")]
            public IssueRestrictions issuerestrictions { get; set; }

            [JsonPropertyName("shouldDisplay")]
            public bool shouldDisplay { get; set; }
        }

        public class IssueRestrictions
        {
        }

        public class Watches
        {
            [JsonPropertyName("self")]
            public string self { get; set; }

            [JsonPropertyName("watchCount")]
            public int watchCount { get; set; }

            [JsonPropertyName("isWatching")]
            public bool isWatching { get; set; }
        }

        public class Priority
        {
            [JsonPropertyName("self")]
            public string self { get; set; }

            [JsonPropertyName("iconUrl")]
            public string iconUrl { get; set; }

            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("id")]
            public string id { get; set; }
        }

        public class Customfield_10018
        {
            [JsonPropertyName("hasEpicLinkFieldDependency")]
            public bool hasEpicLinkFieldDependency { get; set; }

            [JsonPropertyName("showField")]
            public bool showField { get; set; }

            [JsonPropertyName("nonEditableReason")]
            public NonEditableReason nonEditableReason { get; set; }
        }

        public class NonEditableReason
        {
            [JsonPropertyName("reason")]
            public string reason { get; set; }

            [JsonPropertyName("message")]
            public string message { get; set; }
        }

        public class Assignee
        {
            [JsonPropertyName("self")]
            public string self { get; set; }

            [JsonPropertyName("accountId")]
            public string accountId { get; set; }

            [JsonPropertyName("emailAddress")]
            public string emailAddress { get; set; }

            [JsonPropertyName("avatarUrls")]
            public AvatarUrls1 avatarUrls { get; set; }

            [JsonPropertyName("displayName")]
            public string displayName { get; set; }

            [JsonPropertyName("active")]
            public bool active { get; set; }

            [JsonPropertyName("timeZone")]
            public string timeZone { get; set; }

            [JsonPropertyName("accountType")]
            public string accountType { get; set; }
        }

        public class AvatarUrls1
        {

            public string _48x48 { get; set; }
            public string _24x24 { get; set; }
            public string _16x16 { get; set; }
            public string _32x32 { get; set; }
        }

        public class Status
        {
            [JsonPropertyName("self")]
            public string self { get; set; }

            [JsonPropertyName("description")]
            public string description { get; set; }

            [JsonPropertyName("iconUrl")]
            public string iconUrl { get; set; }

            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("id")]
            public string id { get; set; }

            [JsonPropertyName("statusCategory")]
            public StatusCategory statusCategory { get; set; }
        }

        public class StatusCategory
        {
            [JsonPropertyName("self")]
            public string self { get; set; }

            [JsonPropertyName("id")]
            public int id { get; set; }

            [JsonPropertyName("key")]
            public string key { get; set; }
            public string colorName { get; set; }
            public string name { get; set; }
        }

        public class TimeTracking
        {
        }

        public class Creator
        {
            public string self { get; set; }
            public string accountId { get; set; }
            public string emailAddress { get; set; }
            public AvatarUrls2 avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
            public string timeZone { get; set; }
            public string accountType { get; set; }
        }

        public class AvatarUrls2
        {
            public string _48x48 { get; set; }
            public string _24x24 { get; set; }
            public string _16x16 { get; set; }
            public string _32x32 { get; set; }
        }

        public class Reporter
        {
            public string self { get; set; }
            public string accountId { get; set; }
            public string emailAddress { get; set; }
            public AvatarUrls3 avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
            public string timeZone { get; set; }
            public string accountType { get; set; }
        }

        public class AvatarUrls3
        {
            public string _48x48 { get; set; }
            public string _24x24 { get; set; }
            public string _16x16 { get; set; }
            public string _32x32 { get; set; }
        }

        public class AggregateProgress
        {
            public int progress { get; set; }
            public int total { get; set; }
        }

        public class Progress
        {
            public int progress { get; set; }
            public int total { get; set; }
        }

        public class Votes
        {
            public string self { get; set; }
            public int votes { get; set; }
            public bool hasVoted { get; set; }
        }

        public class Comment
        {
            public object[] comments { get; set; }
            public string self { get; set; }
            public int maxResults { get; set; }
            public int total { get; set; }
            public int startAt { get; set; }
        }

        public class Worklog
        {
            public int startAt { get; set; }
            public int maxResults { get; set; }
            public int total { get; set; }
            public object[] worklogs { get; set; }
        }

        public class Customfield_10020
        {
            public int id { get; set; }
            public string name { get; set; }
            public string state { get; set; }
            public int boardId { get; set; }
            public string goal { get; set; }
            public DateTime startDate { get; set; }
            public DateTime endDate { get; set; }
        }

    }
}
