using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OctopusDeployLab.Startup))]
namespace OctopusDeployLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
