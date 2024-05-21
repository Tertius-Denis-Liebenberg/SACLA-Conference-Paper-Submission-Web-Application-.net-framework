using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SACLA_9205.Startup))]
namespace SACLA_9205
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
