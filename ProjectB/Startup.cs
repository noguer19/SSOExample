using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectB.Startup))]
namespace ProjectB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
