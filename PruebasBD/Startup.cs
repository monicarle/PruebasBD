using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebasBD.Startup))]
namespace PruebasBD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
