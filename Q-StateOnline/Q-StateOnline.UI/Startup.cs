using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Q_StateOnline.UI.Startup))]
namespace Q_StateOnline.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
