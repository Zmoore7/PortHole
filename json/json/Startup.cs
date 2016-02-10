using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(json.Startup))]
namespace json
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
