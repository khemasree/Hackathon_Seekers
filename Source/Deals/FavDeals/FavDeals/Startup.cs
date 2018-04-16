using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FavDeals.Startup))]
namespace FavDeals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
