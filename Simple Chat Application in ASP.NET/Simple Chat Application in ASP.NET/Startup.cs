using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Simple_Chat_Application_in_ASP.NET.Startup))]
namespace Simple_Chat_Application_in_ASP.NET
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
