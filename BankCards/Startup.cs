using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankCards.Startup))]
namespace BankCards
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
