using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigHits.Startup))]
namespace BigHits
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
