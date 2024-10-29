namespace OptionPattern.Api
{
    public static class ApiRetryOptionsExtensions
    {
        public static void AddApiRetryOptions(this IServiceCollection services, Action<ApiRetryOptions>? options = null)
        {
            if (options != null) services.Configure(options);
        }
    }
}