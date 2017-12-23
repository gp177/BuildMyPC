using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuildMyPC.Startup))]
namespace BuildMyPC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
