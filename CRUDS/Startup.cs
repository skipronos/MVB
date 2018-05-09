using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDS.Startup))]
namespace CRUDS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
