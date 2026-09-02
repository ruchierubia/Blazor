using BlazorEmployeeManagement.Components;
using BlazorEmployeeManagement.Services.Auth.Temp;
using BlazorEmployeeManagement.Services.Email;
using BlazorEmployeeManagement.Services.Email.Temp;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddControllers();

builder.Services.AddCascadingAuthenticationState();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
    {
        options.LoginPath = "/login";
        options.AccessDeniedPath = "/access-denied";
    });

builder.Services.AddAuthorization();
// singleton for in memory 
builder.Services.AddSingleton<ITempAuthService, TempAuthService>();
builder.Services.AddSingleton<ITempEmployeeService, TempEmployeeService>();

// Email queue
builder.Services.AddSingleton<IEmailQueue, TempEmailQueue>();

// Email sender
builder.Services.AddSingleton<IEmailSender, TempEmailSender>();

// Background email processor
builder.Services.AddHostedService<TempEmailBackgroundService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


app.UseAntiforgery();

app.MapStaticAssets();

app.MapControllers();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
