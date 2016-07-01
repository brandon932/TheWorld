using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheWorld.Startup))]
namespace TheWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
