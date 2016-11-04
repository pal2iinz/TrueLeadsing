using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrueLeadsing2.Startup))]
namespace TrueLeadsing2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
