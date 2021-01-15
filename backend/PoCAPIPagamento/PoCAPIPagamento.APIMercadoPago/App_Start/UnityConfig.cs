using AutoMapper;
using Microsoft.Extensions.Logging;
using PoCAPIPagamento.APIMercadoPago.Controllers;
using PoCAPIPagamento.APIMercadoPago.Services;
using PoCAPIPagamento.APIMercadoPago.Services.Interfaces;
using System.Web.Http;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.WebApi;

namespace PoCAPIPagamento.APIMercadoPago
{
    public static class UnityConfig
    {
        public static void RegisterComponents(HttpConfiguration config)
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            // Registrar novos itens para injeção de dependência aqui:
            // e.g. container.RegisterType<ITestService, TestService>();
            container
                // Registrando Microsoft.Extensions.Logger
                .RegisterType(typeof(ILoggerFactory), typeof(LoggerFactory), new HierarchicalLifetimeManager())
                .RegisterType(typeof(ILogger<>), typeof(Logger<>), new HierarchicalLifetimeManager())

                // Registrando AutoMapper
                .RegisterInstance(MapperConfig.RegisterMappings())

                // Todos os novos serviços precisam ser registrados aqui
                .RegisterType<IPaymentService, PaymentService>(new HierarchicalLifetimeManager())
                .RegisterType<IUserService, UserService>(new HierarchicalLifetimeManager())
                ;

            config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}