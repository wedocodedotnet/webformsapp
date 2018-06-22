using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWebFormsApplication.Startup))]
namespace MyWebFormsApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
