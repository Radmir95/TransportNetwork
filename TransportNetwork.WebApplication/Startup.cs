using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TransportNetwork.WebApplication.Startup))]
namespace TransportNetwork.WebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
