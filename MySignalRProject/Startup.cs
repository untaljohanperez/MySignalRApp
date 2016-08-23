using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySignalRProject.Startup))]
namespace MySignalRProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
