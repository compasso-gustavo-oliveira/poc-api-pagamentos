using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoCAPIPagamento.APIMercadoPago.Models
{
    public class PayerModel
    {
        public string Email { get; set; }
        public IdentificationModel Identification { get; set; }
    }
}