using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMDT_buoi4.Startup))]
namespace TMDT_buoi4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
