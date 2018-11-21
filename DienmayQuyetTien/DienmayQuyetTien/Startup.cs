using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DienmayQuyetTien.Startup))]
namespace DienmayQuyetTien
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
