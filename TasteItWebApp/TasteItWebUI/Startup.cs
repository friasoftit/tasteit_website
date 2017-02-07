using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TasteItWebUI.Startup))]
namespace TasteItWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
