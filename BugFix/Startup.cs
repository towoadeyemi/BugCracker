using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BugFix.Startup))]
namespace BugFix
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
