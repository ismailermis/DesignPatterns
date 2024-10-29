using Microsoft.Extensions.Options;

namespace OptionPattern.Api.GitHub
{
    public static class OptionsBuilderExtentsions
    {
         public static OptionsBuilder<TOptions> ValidateFluentValidation<TOptions>(this OptionsBuilder<TOptions> builder) where TOptions : class
         {
            builder.Services.AddSingleton<IValidateOptions<TOptions>>(
                    serviceProvider=>  new FluentValidateOptions<TOptions>(
                    serviceProvider,builder.Name
                    )
            );
            return builder;
         }
    }
}