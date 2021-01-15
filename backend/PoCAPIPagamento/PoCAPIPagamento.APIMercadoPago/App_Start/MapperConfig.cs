using AutoMapper;
using PoCAPIPagamento.APIMercadoPago.Models;
using MercadoPago.DataStructures.Payment;
using System.ComponentModel;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace PoCAPIPagamento.APIMercadoPago
{
    public static class MapperConfig
    {
        public static IMapper RegisterMappings()
        {
            // Configuração do AutoMapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PaymentModel, MercadoPago.Resources.Payment>();
                cfg.CreateMap<PayerModel, Payer>();
                cfg.CreateMap<IdentificationModel, Identification>()
                    .ForMember(i => i.Number, m => m.MapFrom(i => i.DocNumber))
                    .ForMember(i => i.Type, m => m.MapFrom(i => i.DocType));
            });
            return config.CreateMapper();
        }
    }
}