using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pricener.Startup))]
namespace Pricener
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
