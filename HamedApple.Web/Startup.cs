using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Builder;
using Microsoft.Owin;
using Owin;
using Parbad;
using Parbad.Builder;
using System;
using System.Web.Mvc;
using HamedApple.Web.Controllers;

[assembly: OwinStartupAttribute(typeof(HamedApple.Web.Startup))]
namespace HamedApple.Web
{
    public partial class Startup
    {
        public void ConfigurationServices(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterControllers(typeof(AccountController).Assembly);
            //Parbad builder For Bank Gateway
            var parbadBuilder = ParbadBuilder.CreateDefaultBuilder()
                .ConfigureGateways(gateways =>
                {
                    gateways.AddIdPay().WithAccounts(accounts =>
                    {
                        accounts.AddInMemory(account =>
                        {
                            account.Api = "14e2a12c-667c-4ea0-897a-bf860c69cbc0";
                            account.IsTestAccount = true;
                        });
                    });
                })
                .ConfigureHttpContext(builder => builder.UseOwinFromCurrentHttpContext())
                .ConfigureStorage(builder => builder.UseMemoryCache());
            containerBuilder.Populate(parbadBuilder.Services);
        }
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //
            var containerBuilder = new ContainerBuilder();
            ConfigurationServices(containerBuilder);
            //
            var container = containerBuilder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            app.UseAutofacMiddleware(container);
            app.UseAutofacMvc();

            var serviceProvider = container.Resolve<IServiceProvider>();
            app.UseParbadVirtualGateway(serviceProvider);
        }
    }
}
