using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Markov.Startup))]
namespace Markov
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
