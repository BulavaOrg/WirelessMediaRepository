using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSajt.Startup))]
namespace MVCSajt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
