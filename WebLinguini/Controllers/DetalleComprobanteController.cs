using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebLinguini.Models;
using WebLinguini.Models.DTO;

namespace WebLinguini.Controllers
{
    public class DetalleComprobanteController : Controller
    {
        private ApiRestful detComprobanteApiClient = new ApiRestful();
        static HttpClient client = new HttpClient();

        // GET: Comprobante
        public ActionResult Listar()
        {
            List<DetalleComprobante> model = detComprobanteApiClient.listarDetComprobantes();

            ViewBag.data = model;

            return View();
        }
    }
}