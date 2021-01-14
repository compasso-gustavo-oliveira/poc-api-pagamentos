using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoCAPIPagamento.APIMercadoPago.Models
{
    public class IdentificationModel
    {
        public string DocType { get; set; }
        public string DocNumber { get; set; }
    }
}