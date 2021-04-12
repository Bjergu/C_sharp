using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TAO_SCV_Ready_v_05.Startup))]
namespace TAO_SCV_Ready_v_05
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
