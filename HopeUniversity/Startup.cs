using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HopeUniversity.Startup))]
namespace HopeUniversity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
