using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PoCAPIPagamento.APIMercadoPago.Models.ViewModels
{
    public class TestCardViewModel
    {
        public enum TestCardResponseEnum
        {
            [Description("Pagamento aprovado.")]
            APRO,
            [Description("Pagamento pendente.")]
            CONT,
            [Description("Recusado por erro geral.")]
            OTHE,
            [Description("Recusado com validação para autorizar.")]
            CALL,
            [Description("Recusado por quantia insuficiente.")]
            FUND,
            [Description("Recusado por código de segurança inválido.")]
            SECU,
            [Description("Recusado por problema com a data de vencimento.")]
            EXPI,
            [Description("Recusado por erro no formulário.")]
            FORM
        }
        public CardModel Card { get; set; }
        public string Payer { get; set; }
    }
}