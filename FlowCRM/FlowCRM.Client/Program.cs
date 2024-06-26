using FlowCRM.Client;
using FlowCRM.Client.Services;
using FlowCRM.Shared.Repositories;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.Services.AddScoped<ICustomerRepository, CustomerService>();
builder.Services.AddScoped<IActivityRepository, ActivityService>();
builder.Services.AddScoped<IContactRepository, ContactService>();
builder.Services.AddScoped<ICompanyRepository, CompanyService>();
builder.Services.AddScoped<IDealRepository, DealService>();
builder.Services.AddScoped<IDealStatusRepository, DealStatusService>();
builder.Services.AddScoped<ILeadRepository, LeadService>();
builder.Services.AddScoped<IActivityTypeRepository, ActivityTypeService>();
builder.Services.AddScoped<IPriorityRepository, PriorityService>();

await builder.Build().RunAsync();
