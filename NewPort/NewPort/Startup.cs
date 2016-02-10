using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewPort.Startup))]
namespace NewPort
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
