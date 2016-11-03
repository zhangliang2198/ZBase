using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZBase.Web.Startup))]
namespace ZBase.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
