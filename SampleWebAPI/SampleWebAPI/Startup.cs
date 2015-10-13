using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleWebAPI.Startup))]
namespace SampleWebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
