using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment3_SampleWebApp.Startup))]
namespace Assignment3_SampleWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
