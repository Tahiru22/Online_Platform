using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Online_Platform.Areas.Identity.IdentityHostingStartup))]
namespace Online_Platform.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
            => builder.ConfigureServices((context, services) => { });
    }
}