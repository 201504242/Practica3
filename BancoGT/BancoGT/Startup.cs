using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BancoGT.Startup))]
namespace BancoGT
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
