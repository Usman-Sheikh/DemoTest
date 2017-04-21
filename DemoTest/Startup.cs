using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoTest.Startup))]
namespace DemoTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
