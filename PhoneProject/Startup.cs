using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhoneProject.Startup))]
namespace PhoneProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
