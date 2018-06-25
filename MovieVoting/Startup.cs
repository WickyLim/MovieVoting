using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieVoting.Startup))]
namespace MovieVoting
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
