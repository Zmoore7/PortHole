using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortTest.Startup))]
namespace PortTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
