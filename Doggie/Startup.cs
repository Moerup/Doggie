using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Doggie.Startup))]
namespace Doggie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
