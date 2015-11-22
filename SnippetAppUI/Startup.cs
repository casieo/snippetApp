using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SnippetAppUI.Startup))]
namespace SnippetAppUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
