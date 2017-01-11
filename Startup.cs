using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(My_Web_Site.Startup))]
namespace My_Web_Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
