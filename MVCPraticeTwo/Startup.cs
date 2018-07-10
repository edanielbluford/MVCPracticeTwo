using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPraticeTwo.Startup))]
namespace MVCPraticeTwo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
