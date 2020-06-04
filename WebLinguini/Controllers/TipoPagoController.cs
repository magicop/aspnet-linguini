using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebLinguini.Models;
using WebLinguini.Models.DTO;

namespace WebLinguini.Controllers
{
    public class TipoPagoController : Controller
    {

        private ApiRestful tipopagoApiClient = new ApiRestful();
        static HttpClient client = new HttpClient();

        // GET: TipoPago
        public ActionResult Listar()
        {

            //ViewBag.Result1 = categoriaApiClient.categorias();

            List<TipoPago> model = tipopagoApiClient.listarTipoPagos();

            ViewBag.data = model;

            return View();
        }




    }
}