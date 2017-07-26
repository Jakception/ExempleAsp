using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExempleAsp.Startup))]
namespace ExempleAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
