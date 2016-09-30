using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment3_AspWebApp.Startup))]
namespace Assignment3_AspWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
