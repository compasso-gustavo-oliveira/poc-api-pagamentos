using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PoCAPIPagamento.APIMercadoPago.Models
{
    public class CardModel
    {
        public enum CardModelTypeEnum 
        {
            Mastercard,
            Visa,
            AmericanExpress
        }
        public string Number { get; set; }
        public string SecurityCode { get; set; }
        [RegularExpression("%d%d/%d%d")]
        public string ExpirationDate { get; set; }
        public CardModelTypeEnum Type { get; set; }
    }
}