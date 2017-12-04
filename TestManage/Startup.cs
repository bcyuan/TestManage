using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestManage.Startup))]
namespace TestManage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
