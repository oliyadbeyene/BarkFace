using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarkFace.Startup))]
namespace BarkFace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
