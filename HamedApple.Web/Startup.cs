using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HamedApple.Web.Startup))]
namespace HamedApple.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
