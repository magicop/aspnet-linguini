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
    public class RolController : Controller
    {

        private ApiRestful rolApiClient = new ApiRestful();
        static HttpClient client = new HttpClient();

        // GET: Categoria
        public ActionResult Listar()
        {

            //ViewBag.Result1 = categoriaApiClient.categorias();

            List<Rol> model = rolApiClient.listarRoles();

            ViewBag.data = model;

            return View();
        }

    }
}