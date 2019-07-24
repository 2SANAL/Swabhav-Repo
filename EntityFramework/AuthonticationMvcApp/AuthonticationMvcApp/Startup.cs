using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthonticationMvcApp.Startup))]
namespace AuthonticationMvcApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
