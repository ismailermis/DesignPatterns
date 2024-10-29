namespace OptionPattern.Api.GitHub
{
    public class GitHubSettings
    {
        public const string ConfigurationSeciton = "GitHub";
        public string BaseAddress{ get; init; }=string.Empty;
        public string AccessToken { get; init; }
        public string UserAgent { get; init; }
    }
}