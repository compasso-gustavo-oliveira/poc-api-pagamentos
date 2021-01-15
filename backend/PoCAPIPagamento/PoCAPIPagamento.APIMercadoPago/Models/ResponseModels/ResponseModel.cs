using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoCAPIPagamento.APIMercadoPago.Models.ResponseModels
{
    public class ResponseModel
    {
        public string Message { get; set; } = "Ocorreu um erro inesperado";
        public string[] Errors { get; set; } = Array.Empty<string>();
    }
}