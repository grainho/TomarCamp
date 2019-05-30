using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TomarCamp.Startup))]
namespace TomarCamp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
