using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IC_MVC_tutorial.Startup))]
namespace IC_MVC_tutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
