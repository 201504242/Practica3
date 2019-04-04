using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SitioWEB.Startup))]
namespace SitioWEB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
