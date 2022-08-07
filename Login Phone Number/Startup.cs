using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Login_Phone_Number.Startup))]
namespace Login_Phone_Number
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
