using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLinguini.Models;
using WebLinguini.Models.DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.text.html.simpleparser;
using WebLinguini.Models.ViewModel;
using System.Threading.Tasks;
using System.Net.Http;

namespace WebLinguini.Controllers
{
    public class DetalleCartaController : Controller
    {
        private ApiRestful detalleCartaApiClient = new ApiRestful();
        static HttpClient client = new HttpClient();

        #region Listar
        // GET: DetalleCarta
        public ActionResult Listar()
        {
            List<DetalleCarta> model = detalleCartaApiClient.listarDetalleCarta();

            ViewBag.data = model;
            return View();
        }
        #endregion

        #region Agregar
        public ActionResult FormAgregar()
        {
            return View(new DetalleCartaViewModel());
        }

        [HttpPost]
        public async Task<ActionResult> Agregar(DetalleCartaViewModel c)
        {

            //ViewBag.Result1 = categoriaApiClienat.categorias();

            DetalleCarta ca = new DetalleCarta();
            ca.idCarta = c.idCarta;
            ca.idProducto = c.idProducto;
            ca.cantidadProducto = c.cantidadProducto;

            var result = await agregarDetalleCarta(ca);

            List<DetalleCarta> model = detalleCartaApiClient.listarDetalleCarta();

            ViewBag.data = model;

            return View("Listar", new DetalleCarta());


        }

        public static async Task<Uri> agregarDetalleCarta(DetalleCarta c)
        {
            var url = "http://localhost:8034/api/detalleCarta/" + c.cantidadProducto + "/" + c.idCarta + "/" + c.idProducto + "/agregarDetalleCarta";
            HttpResponseMessage response = await client.PostAsJsonAsync(url, c);

            return response.Headers.Location;
        }

        #endregion

        #region Exportar pdf
        [HttpPost]
        [ValidateInput(false)]
        public FileResult Export(DetalleCarta c)
        {
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(c.Grid);
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Listado-DetalleCarta.pdf");
            }
        }
        #endregion
    }
}