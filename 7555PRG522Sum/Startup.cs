using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_7555PRG522Sum.Startup))]
namespace _7555PRG522Sum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
