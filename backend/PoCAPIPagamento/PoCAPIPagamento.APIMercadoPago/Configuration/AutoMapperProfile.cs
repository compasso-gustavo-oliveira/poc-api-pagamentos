using AutoMapper;
using MercadoPago.DataStructures.AdvancedPayment;
using MercadoPago.Resources;
using PoCAPIPagamento.APIMercadoPago.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoCAPIPagamento.APIMercadoPago.Configuration
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PaymentModel, MercadoPago.Resources.Payment>();
            CreateMap<PayerModel, Payer>();
            CreateMap<IdentificationModel, Identification>()
                .ForMember(i => i.Number, m => m.MapFrom(i => i.DocNumber))
                .ForMember(i => i.Type, m => m.MapFrom(i => i.DocType));
        }
    }
}