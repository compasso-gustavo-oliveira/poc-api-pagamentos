using AutoMapper;
using MercadoPago.Common;
using MercadoPago.Resources;
using PoCAPIPagamento.APIMercadoPago.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoCAPIPagamento.APIMercadoPago.Services
{
    public class PaymentService
    {
        public bool ProcessarPagamento(Payment payment)
        {
            payment.Save();
            var status = payment.Status;
            if (status.HasValue)
                switch (status.Value)
                {
                    case PaymentStatus.pending:
                    case PaymentStatus.approved:
                    case PaymentStatus.authorized:
                    case PaymentStatus.in_process:
                    case PaymentStatus.in_mediation:
                        return true;
                }
            return false;
        }
    }
}