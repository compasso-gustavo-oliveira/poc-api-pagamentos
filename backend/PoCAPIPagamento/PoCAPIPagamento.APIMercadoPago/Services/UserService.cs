using AutoMapper;
using MercadoPago;
using MercadoPago.Common;
using MercadoPago.Resources;
using PoCAPIPagamento.APIMercadoPago.Models;
using PoCAPIPagamento.APIMercadoPago.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoCAPIPagamento.APIMercadoPago.Services
{
    public class UserService : IUserService
    {
        public string Error { get; set; }
        public Customer CadastrarUsuario(Customer customer)
        {
            return customer.Save();
        }
    }
}