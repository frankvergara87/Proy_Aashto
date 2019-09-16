using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIS_Ga2.Startup))]
namespace SIS_Ga2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           /// ConfigureAuth(app);
        }
    }
}
