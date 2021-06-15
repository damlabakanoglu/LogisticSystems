using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TerminalApp.Startup))]
namespace TerminalApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
