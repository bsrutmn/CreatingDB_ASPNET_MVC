using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreatingDB_ASPNET_MVC.Startup))]
namespace CreatingDB_ASPNET_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
