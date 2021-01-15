using AutoMapper;
using MercadoPago.Resources;
using Microsoft.Extensions.Logging;
using PoCAPIPagamento.APIMercadoPago.Models;
using PoCAPIPagamento.APIMercadoPago.Models.ResponseModels;
using PoCAPIPagamento.APIMercadoPago.Services;
using PoCAPIPagamento.APIMercadoPago.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PoCAPIPagamento.APIMercadoPago.Controllers
{
    public class PaymentController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly ILogger<PaymentController> _logger;
        private readonly IPaymentService _service;

        public PaymentController(IMapper mapper, 
                                 ILogger<PaymentController> logger, 
                                 IPaymentService service)
        {
            _mapper = mapper;
            _logger = logger;
            _service = service;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public ResponseModel Post(PaymentModel value)
        {
            var response = new ResponseModel();
            try
            {
                if (_service.ProcessarPagamento(_mapper.Map<Payment>(value)))
                    response.Message = "Pagamento processado com sucesso.";
                else response.Message = "Não foi possível processar o pagamento.";
                _logger.LogInformation(response.Message);
            }
            catch (Exception ex)
            {
                response.Message = "Ocorreu um ou mais erros ao processar o pagamento.";
                _logger.LogError(ex, response.Message);
            }
            return response;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
