using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APIXUWebSample.Startup))]
namespace APIXUWebSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
