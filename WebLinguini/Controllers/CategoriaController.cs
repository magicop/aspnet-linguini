using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebLinguini.Models;
using WebLinguini.Models.DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.text.html.simpleparser;


namespace WebLinguini.Controllers
{
    public class CategoriaController : Controller
    {

        private ApiRestful categoriaApiClient = new ApiRestful();
        static HttpClient client = new HttpClient();

        // GET: Categoria
        public ActionResult Listar()
        {

            //ViewBag.Result1 = categoriaApiClient.categorias();

            List<Categoria> model = categoriaApiClient.listarCategorias();

            ViewBag.data = model;

            return View();
        }

        #region Agregar
        [HttpPost]

        public async Task<ActionResult> Agregar(Categoria c)
        {
            try
            {
                //ViewBag.Result1 = categoriaApiClienat.categorias();

                var result = await agregarCategoria(c);

                List<Categoria> model = categoriaApiClient.listarCategorias();

                ViewBag.data = model;

                return View("Index");
            }
            catch
            {
                return RedirectToAction("Error");
            }

        }

        public ActionResult FormAgregar(Categoria c)
        {
            return View();

        }

        public static async Task<Uri> agregarCategoria(Categoria c)
        {
            var url = "http://localhost:8034/api/categoria/addcategoria/";
            HttpResponseMessage response = await client.PostAsJsonAsync(url, c);

            return response.Headers.Location;
        }
        #endregion

        #region Editar
        [HttpPost]

        public async Task<ActionResult> Editar(Categoria c)
        {
            try
            {
                //ViewBag.Result1 = categoriaApiClienat.categorias();

                var result = await editarCategoria(c);

                List<Categoria> model = categoriaApiClient.listarCategorias();

                ViewBag.data = model;

                return View("Index");
            }
            catch
            {
                return RedirectToAction("Error");
            }

        }

        public ActionResult FormEditar(Categoria c)
        {
            return View();

        }

        public static async Task<Categoria> editarCategoria(Categoria c)
        {
            var url = "http://localhost:8034/api/categoria/" + c.idCategoria;
            HttpResponseMessage response = await client.PostAsJsonAsync(url, c);
            response.EnsureSuccessStatusCode();

            c = await response.Content.ReadAsAsync<Categoria>();

            return c;
        }
        #endregion

        #region Eliminar
        [HttpPost]

        public async Task<ActionResult> Eliminar(Categoria c)
        {
            try
            {
                //ViewBag.Result1 = categoriaApiClienat.categorias();

                var result = await eliminarCategoria(c);

                List<Categoria> model = categoriaApiClient.listarCategorias();

                ViewBag.data = model;

                return View("Index");
            }
            catch
            {
                return RedirectToAction("Error");
            }

        }

        public ActionResult FormEliminar(Categoria c)
        {
            return View();

        }

        public static async Task<HttpStatusCode> eliminarCategoria(Categoria c)
        {
            var url = "http://localhost:8034/api/categoria/" + c.idCategoria;
            HttpResponseMessage response = await client.DeleteAsync(url);
            response.EnsureSuccessStatusCode();

            return response.StatusCode;
        }
        #endregion

        #region Exportar pdf
        [HttpPost]
        [ValidateInput(false)]
        public FileResult Export(Categoria c)
        {
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(c.Grid);
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Listado-Categorias.pdf");
            }
        }
        #endregion


    }
}