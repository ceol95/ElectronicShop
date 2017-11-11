using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElectronicShop.Startup))]
namespace ElectronicShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
