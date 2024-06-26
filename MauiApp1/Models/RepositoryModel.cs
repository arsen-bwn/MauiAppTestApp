namespace MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



    public partial class RepositoryModel
{
        [JsonProperty("id", Required = Required.Always)]
        public long Id { get; set; }

        [JsonProperty("node_id", Required = Required.Always)]
        public string NodeId { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("full_name", Required = Required.Always)]
        public string FullName { get; set; }

        [JsonProperty("private", Required = Required.Always)]
        public bool Private { get; set; }

        [JsonProperty("owner", Required = Required.Always)]
        public Owner Owner { get; set; }

        [JsonProperty("html_url", Required = Required.Always)]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("description", Required = Required.Always)]
        public string Description { get; set; }

        [JsonProperty("fork", Required = Required.Always)]
        public bool Fork { get; set; }

        [JsonProperty("url", Required = Required.Always)]
        public Uri Url { get; set; }

        [JsonProperty("forks_url", Required = Required.Always)]
        public Uri ForksUrl { get; set; }

        [JsonProperty("keys_url", Required = Required.Always)]
        public string KeysUrl { get; set; }

        [JsonProperty("collaborators_url", Required = Required.Always)]
        public string CollaboratorsUrl { get; set; }

        [JsonProperty("teams_url", Required = Required.Always)]
        public Uri TeamsUrl { get; set; }

        [JsonProperty("hooks_url", Required = Required.Always)]
        public Uri HooksUrl { get; set; }

        [JsonProperty("issue_events_url", Required = Required.Always)]
        public string IssueEventsUrl { get; set; }

        [JsonProperty("events_url", Required = Required.Always)]
        public Uri EventsUrl { get; set; }

        [JsonProperty("assignees_url", Required = Required.Always)]
        public string AssigneesUrl { get; set; }

        [JsonProperty("branches_url", Required = Required.Always)]
        public string BranchesUrl { get; set; }

        [JsonProperty("tags_url", Required = Required.Always)]
        public Uri TagsUrl { get; set; }

        [JsonProperty("blobs_url", Required = Required.Always)]
        public string BlobsUrl { get; set; }

        [JsonProperty("git_tags_url", Required = Required.Always)]
        public string GitTagsUrl { get; set; }

        [JsonProperty("git_refs_url", Required = Required.Always)]
        public string GitRefsUrl { get; set; }

        [JsonProperty("trees_url", Required = Required.Always)]
        public string TreesUrl { get; set; }

        [JsonProperty("statuses_url", Required = Required.Always)]
        public string StatusesUrl { get; set; }

        [JsonProperty("languages_url", Required = Required.Always)]
        public Uri LanguagesUrl { get; set; }

        [JsonProperty("stargazers_url", Required = Required.Always)]
        public Uri StargazersUrl { get; set; }

        [JsonProperty("contributors_url", Required = Required.Always)]
        public Uri ContributorsUrl { get; set; }

        [JsonProperty("subscribers_url", Required = Required.Always)]
        public Uri SubscribersUrl { get; set; }

        [JsonProperty("subscription_url", Required = Required.Always)]
        public Uri SubscriptionUrl { get; set; }

        [JsonProperty("commits_url", Required = Required.Always)]
        public string CommitsUrl { get; set; }

        [JsonProperty("git_commits_url", Required = Required.Always)]
        public string GitCommitsUrl { get; set; }

        [JsonProperty("comments_url", Required = Required.Always)]
        public string CommentsUrl { get; set; }

        [JsonProperty("issue_comment_url", Required = Required.Always)]
        public string IssueCommentUrl { get; set; }

        [JsonProperty("contents_url", Required = Required.Always)]
        public string ContentsUrl { get; set; }

        [JsonProperty("compare_url", Required = Required.Always)]
        public string CompareUrl { get; set; }

        [JsonProperty("merges_url", Required = Required.Always)]
        public Uri MergesUrl { get; set; }

        [JsonProperty("archive_url", Required = Required.Always)]
        public string ArchiveUrl { get; set; }

        [JsonProperty("downloads_url", Required = Required.Always)]
        public Uri DownloadsUrl { get; set; }

        [JsonProperty("issues_url", Required = Required.Always)]
        public string IssuesUrl { get; set; }

        [JsonProperty("pulls_url", Required = Required.Always)]
        public string PullsUrl { get; set; }

        [JsonProperty("milestones_url", Required = Required.Always)]
        public string MilestonesUrl { get; set; }

        [JsonProperty("notifications_url", Required = Required.Always)]
        public string NotificationsUrl { get; set; }

        [JsonProperty("labels_url", Required = Required.Always)]
        public string LabelsUrl { get; set; }

        [JsonProperty("releases_url", Required = Required.Always)]
        public string ReleasesUrl { get; set; }

        [JsonProperty("deployments_url", Required = Required.Always)]
        public Uri DeploymentsUrl { get; set; }

        [JsonProperty("created_at", Required = Required.Always)]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at", Required = Required.Always)]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("pushed_at", Required = Required.Always)]
        public DateTimeOffset PushedAt { get; set; }

        [JsonProperty("git_url", Required = Required.Always)]
        public string GitUrl { get; set; }

        [JsonProperty("ssh_url", Required = Required.Always)]
        public string SshUrl { get; set; }

        [JsonProperty("clone_url", Required = Required.Always)]
        public Uri CloneUrl { get; set; }

        [JsonProperty("svn_url", Required = Required.Always)]
        public Uri SvnUrl { get; set; }

        [JsonProperty("homepage", Required = Required.AllowNull)]
        public object Homepage { get; set; }

        [JsonProperty("size", Required = Required.Always)]
        public long Size { get; set; }

        [JsonProperty("stargazers_count", Required = Required.Always)]
        public long StargazersCount { get; set; }

        [JsonProperty("watchers_count", Required = Required.Always)]
        public long WatchersCount { get; set; }

        [JsonProperty("language", Required = Required.AllowNull)]
        public object Language { get; set; }

        [JsonProperty("has_issues", Required = Required.Always)]
        public bool HasIssues { get; set; }

        [JsonProperty("has_projects", Required = Required.Always)]
        public bool HasProjects { get; set; }

        [JsonProperty("has_downloads", Required = Required.Always)]
        public bool HasDownloads { get; set; }

        [JsonProperty("has_wiki", Required = Required.Always)]
        public bool HasWiki { get; set; }

        [JsonProperty("has_pages", Required = Required.Always)]
        public bool HasPages { get; set; }

        [JsonProperty("has_discussions", Required = Required.Always)]
        public bool HasDiscussions { get; set; }

        [JsonProperty("forks_count", Required = Required.Always)]
        public long ForksCount { get; set; }

        [JsonProperty("mirror_url", Required = Required.AllowNull)]
        public object MirrorUrl { get; set; }

        [JsonProperty("archived", Required = Required.Always)]
        public bool Archived { get; set; }

        [JsonProperty("disabled", Required = Required.Always)]
        public bool Disabled { get; set; }

        [JsonProperty("open_issues_count", Required = Required.Always)]
        public long OpenIssuesCount { get; set; }

        [JsonProperty("license", Required = Required.AllowNull)]
        public object License { get; set; }

        [JsonProperty("allow_forking", Required = Required.Always)]
        public bool AllowForking { get; set; }

        [JsonProperty("is_template", Required = Required.Always)]
        public bool IsTemplate { get; set; }

        [JsonProperty("web_commit_signoff_required", Required = Required.Always)]
        public bool WebCommitSignoffRequired { get; set; }

        [JsonProperty("topics", Required = Required.Always)]
        public List<object> Topics { get; set; }

        [JsonProperty("visibility", Required = Required.Always)]
        public string Visibility { get; set; }

        [JsonProperty("forks", Required = Required.Always)]
        public long Forks { get; set; }

        [JsonProperty("open_issues", Required = Required.Always)]
        public long OpenIssues { get; set; }

        [JsonProperty("watchers", Required = Required.Always)]
        public long Watchers { get; set; }

        [JsonProperty("default_branch", Required = Required.Always)]
        public string DefaultBranch { get; set; }

        [JsonProperty("permissions", Required = Required.Always)]
        public Permissions Permissions { get; set; }
    }

    public partial class Owner
    {
        [JsonProperty("login", Required = Required.Always)]
        public string Login { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public long Id { get; set; }

        [JsonProperty("node_id", Required = Required.Always)]
        public string NodeId { get; set; }

        [JsonProperty("avatar_url", Required = Required.Always)]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("gravatar_id", Required = Required.Always)]
        public string GravatarId { get; set; }

        [JsonProperty("url", Required = Required.Always)]
        public Uri Url { get; set; }

        [JsonProperty("html_url", Required = Required.Always)]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("followers_url", Required = Required.Always)]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url", Required = Required.Always)]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url", Required = Required.Always)]
        public string GistsUrl { get; set; }

        [JsonProperty("starred_url", Required = Required.Always)]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url", Required = Required.Always)]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url", Required = Required.Always)]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("repos_url", Required = Required.Always)]
        public Uri ReposUrl { get; set; }

        [JsonProperty("events_url", Required = Required.Always)]
        public string EventsUrl { get; set; }

        [JsonProperty("received_events_url", Required = Required.Always)]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; set; }

        [JsonProperty("site_admin", Required = Required.Always)]
        public bool SiteAdmin { get; set; }
    }

    public partial class Permissions
    {
        [JsonProperty("admin", Required = Required.Always)]
        public bool Admin { get; set; }

        [JsonProperty("maintain", Required = Required.Always)]
        public bool Maintain { get; set; }

        [JsonProperty("push", Required = Required.Always)]
        public bool Push { get; set; }

        [JsonProperty("triage", Required = Required.Always)]
        public bool Triage { get; set; }

        [JsonProperty("pull", Required = Required.Always)]
        public bool Pull { get; set; }
    }

