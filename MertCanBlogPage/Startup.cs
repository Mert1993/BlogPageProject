using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MertCanBlogPage.Startup))]
namespace MertCanBlogPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
