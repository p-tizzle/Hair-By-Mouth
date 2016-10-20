using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hairByMouth2.Startup))]
namespace hairByMouth2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
