using MercadoPago.DataStructures.Generic;
using Microsoft.Extensions.Logging;
using PoCAPIPagamento.APIMercadoPago.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PoCAPIPagamento.APIMercadoPago.Controllers
{
    public abstract class MercadoPagoController : ApiController
    {
        protected readonly NameValueCollection _settings = ConfigurationManager.AppSettings;
        protected readonly ILogger _logger;

        public MercadoPagoController(ILogger logger)
        {
            _logger = logger;
        }

        protected void HandleErrors(Exception ex, 
                                    ResponseModel response, 
                                    string message = "Ocorreu um erro inesperado.")
        {
            response.Message = message;
            var debug = false;
            bool.TryParse(_settings["debug"], out debug);
            if (debug)
            {
                response.Errors = new string[] { ex.StackTrace };
            }
            _logger.LogError(ex, response.Message);
        }

        protected void HandleErrors(BadParamsError error, 
                                    ResponseModel response, 
                                    string message = "Ocorreu um erro inesperado.")
        {
            response.Message = message;
            bool.TryParse(_settings["debug"], out bool debug);
            if (debug)
            {
                response.Errors = new string[] { error.Message };
            }
            _logger.LogError($"{response.Message}: {error.Message}");
        }
    }
}
