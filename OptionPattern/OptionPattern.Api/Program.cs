using FluentValidation;
using Microsoft.Extensions.Options;
using OptionPattern.Api;
using OptionPattern.Api.GitHub;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

/* 
var environment = builder.Environment.EnvironmentName;

builder.Configuration
.AddJsonFile($"appsettings.{environment}.json",optional:false)// if it false the file is required
.AddJsonFile("appsettings.local.json",optional:true);// you dont send to git repo
*/
 
builder.Services.Configure<PlayerSettings>(builder.Configuration.GetSection("PlayerSettings"));
 
 
//builder.Services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddSingleton<IOptionsMonitor<AppSettings>, OptionsMonitor<AppSettings>>();
/*
With IOptionsMonitor, you can react to configuration changes in real-time without needing to restart your application.
IOptionsSnapshot is yet another tool in your configuration toolbox. It provides a scoped view of configuration settings, 
ideal for short-lived operations or background tasks. To use it, follow the same setup as with 
IOptionsSnapshot provides a snapshot of configuration values, which is scoped to the current request or operation. 
This is particularly useful in scenarios where you need a unique set of configuration values for each user or operation.
*/

builder.Services.AddApiRetryOptions(options=>{
    options.MaxRetries = 15;
    options.MaxRetries= 4000;
});
//*************** Option For Validation Setting Method 1*****************
// builder.Services.AddOptions<GitHubSettings>()
// .BindConfiguration(GitHubSettings.ConfigurationSeciton)
// .ValidateDataAnnotations()
// .ValidateOnStart();
// --------- Method 2 -------------------------------------------- 
builder.Services.AddOptionsValidationWithFluentValidation<GitHubSettings>(GitHubSettings.ConfigurationSeciton);

builder.Services.AddHttpClient<GitHubSettings>((sp,httpClient)=>{
    var gitHubSettings = sp.GetRequiredService<IOptions<GitHubSettings>>().Value;
    httpClient.DefaultRequestHeaders.Add("Authorization", gitHubSettings.AccessToken);
    httpClient.DefaultRequestHeaders.Add("User-Agent", gitHubSettings.UserAgent);
    httpClient.BaseAddress = new Uri(gitHubSettings.BaseAddress);
});
//---------- FluentValidation ----------------------------------
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);

//--------------------------------------------------------------
//************************************************************************
     
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
try
{
    app.Run();
}
catch (System.Exception ex)
{
    Console.WriteLine(ex);
    throw;
}

 