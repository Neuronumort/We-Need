using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(We_Need.Startup))]
namespace We_Need
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
