using MercadoPago.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCAPIPagamento.APIMercadoPago.Services.Interfaces
{
    public interface IPaymentService
    {
        bool ProcessarPagamento(Payment payment);
    }
}
