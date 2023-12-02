using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trofimovs_Ar_paliglidzekliem_paraugs.Startup))]
namespace Trofimovs_Ar_paliglidzekliem_paraugs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
