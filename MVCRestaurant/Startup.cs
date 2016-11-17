using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRestaurant.Startup))]
namespace MVCRestaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
