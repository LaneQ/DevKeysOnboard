using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevKeysOnboarding.Startup))]
namespace DevKeysOnboarding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
