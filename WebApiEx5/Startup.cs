using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApiEx5.Startup))]
namespace WebApiEx5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
