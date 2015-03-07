using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StatsdMVCTemplate.Startup))]
namespace StatsdMVCTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
