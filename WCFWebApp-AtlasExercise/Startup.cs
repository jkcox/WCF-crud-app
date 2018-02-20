using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WCFWebApp_AtlasExercise.Startup))]
namespace WCFWebApp_AtlasExercise
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
