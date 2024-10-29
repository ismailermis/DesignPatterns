namespace OptionPattern.Api
{
    public class ApiRetryOptions
    {
        public int MaxRetries { get; set; } = 3;
        public int DelayInSeconds { get; set; } = 1000;
    }
}