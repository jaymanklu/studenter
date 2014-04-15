using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InRonStudenter.MVCWeb.Startup))]
namespace InRonStudenter.MVCWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
