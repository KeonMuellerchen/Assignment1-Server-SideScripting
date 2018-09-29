using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assign1.Startup))]
namespace Assign1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
