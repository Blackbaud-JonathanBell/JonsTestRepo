using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebService.Startup))]
namespace TestWebService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
