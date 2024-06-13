using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Online_Platform.Data;
using Online_Platform.Infrastructure.Configurations;
using Online_Platform.Infrastructure.Constant;
using Online_Platform.Models;
using Online_Platform.Services;
using Online_Platform.Services.Models.EmailSender;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<OnlineDbContext>(options => options
                .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddIdentity<User, IdentityRole>(options => options
                   .SignIn.RequireConfirmedAccount = false) // App User
                                                          //.AddDefaultUI(UIFramework.Bootstrap4)
               .AddEntityFrameworkStores<OnlineDbContext>()
               .AddDefaultTokenProviders();

 // Password & User settings
builder.Services.Configure<DataProtectionTokenProviderOptions>(o => o.TokenLifespan = TimeSpan.FromHours(3));

// External Authentication providers
builder.Services
    .AddAuthentication()
    .AddFacebook(options =>
    {
        /// Facebook AppId & AppSecret intentionally removed from appsettings => add credentials to secrets.json
        options.AppId = builder.Configuration[WebConstants.AuthFacebookAppId];
        options.AppSecret = builder.Configuration[WebConstants.AuthFacebookAppSecret];
    })
    .AddGoogle(options =>
    {
        /// Google ClientId & ClientSecret intentionally removed from appsettings => add credentials to secrets.json
        options.ClientId = builder.Configuration[WebConstants.AuthGoogleClientId];
        options.ClientSecret = builder.Configuration[WebConstants.AuthGoogleClientSecret];
    });


// App Services
builder.Services.AddDomainServices();

/// Cloudinary ApiKey & ApiSecret intentionally removed from appsettings => add credentials to secrets.json
builder.Services.AddCloudinaryService(
    builder.Configuration[WebConstants.AuthCloudinaryCloudName],
    builder.Configuration[WebConstants.AuthCloudinaryApiKey],
    builder.Configuration[WebConstants.AuthCloudinaryApiSecret]);

// Email Sender
/// SendGrid ApiKey intentionally removed from appsettings => add credentials to secrets.json
builder.Services.Configure<EmailSenderOptions>(builder.Configuration.GetSection("Authentication:SendGrid"));

builder.Services.AddMemoryCache();

builder.Services.AddSession();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(builder.GetType());

builder.Services.AddRoutingOptions(); // Lowercase URLs & query strings

builder.Services.AddMvcOptions(); // Global filters & Identity

builder.Services.ConfigureApplicationCookieOptions();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
