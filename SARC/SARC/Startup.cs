using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SARC.Startup))]
namespace SARC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
