using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WarDragons.Startup))]
namespace WarDragons
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
