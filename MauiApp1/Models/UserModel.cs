using Newtonsoft.Json;

namespace MauiApp1.Models;

public class UserModel
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

    [JsonProperty("name", Required = Required.AllowNull)]
    public object Name { get; set; }

    [JsonProperty("company", Required = Required.AllowNull)]
    public object Company { get; set; }

    [JsonProperty("blog", Required = Required.Always)]
    public string Blog { get; set; }

    [JsonProperty("location", Required = Required.AllowNull)]
    public object Location { get; set; }

    [JsonProperty("email", Required = Required.AllowNull)]
    public object Email { get; set; }

    [JsonProperty("hireable", Required = Required.AllowNull)]
    public object Hireable { get; set; }

    [JsonProperty("bio", Required = Required.AllowNull)]
    public object Bio { get; set; }

    [JsonProperty("twitter_username", Required = Required.AllowNull)]
    public object TwitterUsername { get; set; }

    [JsonProperty("public_repos", Required = Required.Always)]
    public long PublicRepos { get; set; }

    [JsonProperty("public_gists", Required = Required.Always)]
    public long PublicGists { get; set; }

    [JsonProperty("followers", Required = Required.Always)]
    public long Followers { get; set; }

    [JsonProperty("following", Required = Required.Always)]
    public long Following { get; set; }

    [JsonProperty("created_at", Required = Required.Always)]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonProperty("updated_at", Required = Required.Always)]
    public DateTimeOffset UpdatedAt { get; set; }
}