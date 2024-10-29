using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace OptionPattern.Api.GitHub
{
    public sealed class GitHuıbSettingsValidator :AbstractValidator<GitHubSettings>
    {
        public GitHuıbSettingsValidator(){
            RuleFor(x=>x.AccessToken).NotEmpty();
            RuleFor(x=>x.UserAgent).NotEmpty();
            RuleFor(x=>x.BaseAddress).NotEmpty();
            RuleFor(x=>x.BaseAddress)
                .Must(baseAddress => Uri.TryCreate(baseAddress, UriKind.Absolute, out _))
                .When(x => !string.IsNullOrWhiteSpace(x.BaseAddress))
                .WithMessage($"{nameof(GitHubSettings.BaseAddress)} must be a valid URL");
        }
    }
}