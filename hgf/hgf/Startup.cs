using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hgf.Startup))]
namespace hgf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
