using System.Diagnostics;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var webApplicationOptions = new WebApplicationOptions
{
	//EnvironmentName = Environments.Production,
	//EnvironmentName = Environments.Development,

	EnvironmentName =
		Debugger.IsAttached ? Environments.Development : Environments.Production,
};

var builder =
	WebApplication.CreateBuilder(options: webApplicationOptions);

builder.Services.AddRazorPages();
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
	endpoints.MapDefaultControllerRoute();
});

app.Run();
