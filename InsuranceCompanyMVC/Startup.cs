using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InsuranceCompanyMVC.Startup))]
namespace InsuranceCompanyMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
