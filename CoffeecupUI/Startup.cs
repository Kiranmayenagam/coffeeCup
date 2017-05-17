using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoffeecupUI.Startup))]
namespace CoffeecupUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
