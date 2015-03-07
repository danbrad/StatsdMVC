using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StatsdMVC.Startup))]
namespace StatsdMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
