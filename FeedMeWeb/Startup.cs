using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FeedMeWeb.Startup))]
namespace FeedMeWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
