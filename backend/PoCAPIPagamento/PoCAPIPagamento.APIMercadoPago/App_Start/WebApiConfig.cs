using AutoMapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using Microsoft.Extensions.DependencyInjection;
using PoCAPIPagamento.APIMercadoPago.Services;
using Unity;
using PoCAPIPagamento.APIMercadoPago.Services.Interfaces;
using Unity.Lifetime;
using PoCAPIPagamento.APIMercadoPago.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace PoCAPIPagamento.APIMercadoPago
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configurar injeção de dependências
            UnityConfig.RegisterComponents(config);

            // Serviços e configuração da API da Web

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var settings = ConfigurationManager.AppSettings;

            MercadoPago.SDK.SetAccessToken(settings["APIKeys:AccessToken"]);
        }
    }
}
