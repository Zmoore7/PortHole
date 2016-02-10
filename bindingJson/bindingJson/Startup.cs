using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bindingJson.Startup))]
namespace bindingJson
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
