using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusinessDiary.Web.Startup))]
namespace BusinessDiary.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
