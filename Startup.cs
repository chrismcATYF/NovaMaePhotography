using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NovaMaePhotography.Startup))]
namespace NovaMaePhotography
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
