using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyMission.Presentation.Startup))]
namespace EasyMission.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
