using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebLinguini.Models;
using WebLinguini.Models.DTO;

namespace WebLinguini.Controllers
{
    public class UsuarioController : Controller
    {

        private ApiRestful usuarioApiController = new ApiRestful();
        static HttpClient client = new HttpClient();

        // GET: Usuario
        public ActionResult Index()
        {
            //List<Usuario> model = usuarioApiController.listaUsuarios();

            //ViewBag.data = model;

            return View();
        }


        #region Buscar
        [HttpGet]
        public async Task<ActionResult> Buscar(Usuario u)
        {

            var result = await getUsuario(u);

            if (result != null)
            {
                ViewBag.data = "yes";
                return View();
            }
            else
            {
                ViewBag.data = "no";
                return View();
            }
                
        }

        [HttpGet]
        public static async Task<Usuario> getUsuario(Usuario c)
        {
            Usuario u = null;
            var url = "http://localhost:8034/api/usuario/" + c.username + "/" + c.password;
            HttpResponseMessage response = await client.GetAsync(url);
            HttpContent content = response.Content;
            var result2 = await response.Content.ReadAsAsync<Usuario>();
            string result = await content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                u = await response.Content.ReadAsAsync<Usuario>();
            }
            return u;
        }
        #endregion

        
    }

}