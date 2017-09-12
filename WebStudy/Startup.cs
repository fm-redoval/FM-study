using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebStudy.Startup))]
namespace WebStudy
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
