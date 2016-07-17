using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VectorManagementSystem.Startup))]
namespace VectorManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
