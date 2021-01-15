using MercadoPago;
using MercadoPago.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCAPIPagamento.APIMercadoPago.Services.Interfaces
{
    public interface IUserService
    {
        Customer CadastrarUsuario(Customer user);
    }
}
