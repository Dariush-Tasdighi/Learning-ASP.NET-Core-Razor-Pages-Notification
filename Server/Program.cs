// **************************************************
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
// **************************************************

// **************************************************
var webApplicationOptions =
	new Microsoft.AspNetCore.Builder.WebApplicationOptions
	{
		EnvironmentName =
			System.Diagnostics.Debugger.IsAttached ?
			Microsoft.Extensions.Hosting.Environments.Development
			:
			Microsoft.Extensions.Hosting.Environments.Production,
	};

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(options: webApplicationOptions);
// **************************************************

// **************************************************
// AddHttpContextAccessor() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddHttpContextAccessor();
// **************************************************

// **************************************************
// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddRazorPages();
// **************************************************

// **************************************************
// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddControllersWithViews();
// **************************************************

// **************************************************
var app =
	builder.Build();
// **************************************************

// **************************************************
// UseHttpsRedirection() -> using Microsoft.AspNetCore.Builder;
app.UseHttpsRedirection();
// **************************************************

// **************************************************
// UseStaticFiles() -> using Microsoft.AspNetCore.Builder;
app.UseStaticFiles();
// **************************************************

// **************************************************
// UseRouting() -> using Microsoft.AspNetCore.Builder;
app.UseRouting();
// **************************************************

// **************************************************
// UseAuthentication() -> using Microsoft.AspNetCore.Builder;
app.UseAuthentication();
// **************************************************

// **************************************************
// UseAuthentication() -> using Microsoft.AspNetCore.Builder;
app.UseAuthorization();
// **************************************************

// **************************************************
// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
app.MapRazorPages();
// **************************************************

// **************************************************
// UseEndpoints() -> using Microsoft.AspNetCore.Builder;
app.UseEndpoints(endpoints =>
{
	// MapDefaultControllerRoute() -> using Microsoft.AspNetCore.Builder;
	endpoints.MapDefaultControllerRoute();
});
// **************************************************

// **************************************************
app.Run();
// **************************************************
