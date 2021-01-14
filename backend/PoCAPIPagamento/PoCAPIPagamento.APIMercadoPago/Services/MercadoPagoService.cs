using AutoMapper;
using MercadoPago.Resources;
using PoCAPIPagamento.APIMercadoPago.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoCAPIPagamento.APIMercadoPago.Services
{
    public class MercadoPagoService
    {
        private readonly IMapper _mapper;

        public MercadoPagoService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public void ProcessarPagamento(PaymentModel payment)
        {
            var p = _mapper.Map<Payment>(payment);
            p.Save();
        }
    }
}