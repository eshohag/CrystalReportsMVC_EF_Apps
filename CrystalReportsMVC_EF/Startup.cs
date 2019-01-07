using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrystalReportsMVC_EF.Startup))]
namespace CrystalReportsMVC_EF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
