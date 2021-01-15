using AutoMapper;
using PoCAPIPagamento.APIMercadoPago.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using Microsoft.Extensions.DependencyInjection;

namespace PoCAPIPagamento.APIMercadoPago
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuração do AutoMapper
            var mapperCfg = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());

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
