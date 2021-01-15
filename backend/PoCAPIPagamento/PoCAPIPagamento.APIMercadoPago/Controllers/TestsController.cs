using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PoCAPIPagamento.APIMercadoPago.Controllers
{
    public class TestsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Testes API Mercado Pago";

            return View();
        }

        public ActionResult Cards()
        {
            ViewBag.Title = "Testes API Mercado Pago - Cartões";

            return View();
        }
    }
}
