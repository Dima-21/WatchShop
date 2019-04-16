using Microsoft.Owin;
using Owin;
using System.Web.Mvc;
using WatchShop.Infrastructure;

[assembly: OwinStartupAttribute(typeof(WatchShop.Startup))]
namespace WatchShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            DependencyResolver.SetResolver(new ShopDependencyResolver());
        }
    }
}
