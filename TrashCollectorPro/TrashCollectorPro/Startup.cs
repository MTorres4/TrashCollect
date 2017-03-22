using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashCollectorPro.Startup))]
namespace TrashCollectorPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
