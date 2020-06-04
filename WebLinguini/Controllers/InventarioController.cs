using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLinguini.Models;
using WebLinguini.Models.DTO;

namespace WebLinguini.Controllers
{
    public class InventarioController : Controller
    {


        private ApiRestful inventarioController = new ApiRestful();


        // GET: Inventario
        public ActionResult Listar()
        {
            List<Inventario> model = inventarioController.listarInventarios();

            ViewBag.data = model;

            return View();
        }
    }
}