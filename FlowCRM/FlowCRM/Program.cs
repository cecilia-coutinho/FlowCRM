using FlowCRM.Client.Pages;
using FlowCRM.Components;
using FlowCRM.Components.Account;
using FlowCRM.Data;
using FlowCRM.Implementations;
using FlowCRM.Shared.Repositories;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
		.AddInteractiveServerComponents()
		.AddInteractiveWebAssemblyComponents();

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
		c.SwaggerDoc("v1", new OpenApiInfo { Title = "FlowCRM API", Version = "v1" });
});

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, PersistingServerAuthenticationStateProvider>();

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

builder.Services.AddScoped(http => new HttpClient
{
	BaseAddress = new Uri(builder.Configuration.GetSection("BaseAddress").Value!)
});

builder.Services.AddAuthorization();
builder.Services.AddAuthentication(options =>
{
		options.DefaultScheme = IdentityConstants.ApplicationScheme;
		options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
		.AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
		options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
		.AddRoles<IdentityRole>()
		.AddEntityFrameworkStores<ApplicationDbContext>()
		.AddSignInManager()
		.AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
		app.UseWebAssemblyDebugging();
		app.UseMigrationsEndPoint();

		app.UseSwagger();
		app.UseSwaggerUI(c =>
		{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "FlowCRM API V1");
		});
}
else
{
		app.UseExceptionHandler("/Error", createScopeForErrors: true);
		// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
		app.UseHsts();
}

app.UseHttpsRedirection();

app.MapControllers();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
		.AddInteractiveServerRenderMode()
		.AddInteractiveWebAssemblyRenderMode()
		.AddAdditionalAssemblies(typeof(FlowCRM.Client._Imports).Assembly);

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();
