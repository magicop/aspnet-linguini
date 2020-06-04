using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebLinguini.Models;
using WebLinguini.Models.DTO;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.text.html.simpleparser;
using WebLinguini.Models.ViewModel;

namespace WebLinguini.Controllers
{
    public class CartaController : Controller
    {

        private ApiRestful cartaApiController = new ApiRestful();
        static HttpClient client = new HttpClient();

        // GET: Carta
        public ActionResult Listar()
        {
            List<Carta2> model = cartaApiController.listarCartas();

            ViewBag.data = model;

            return View(new Carta());
        }

        #region Formularios
        public ActionResult FormAgregar()
        {
            return View(new Carta());
        }

        public ActionResult FormActualizar()
        {
            return View();
        }

        public ActionResult FormEliminar()
        {
            return View();
        }

        public ActionResult FormBuscar()
        {
            return View(new CartaViewModel());
        }
        #endregion

        #region Agregar
        [HttpPost]
        public async Task<ActionResult> Agregar(Carta2 c)
        {
            
            //ViewBag.Result1 = categoriaApiClienat.categorias();

            var result = await agregarCarta(c);

            List<Carta2> model = cartaApiController.listarCartas();                

            ViewBag.data = model;

            return View("Listar", new Carta());
 

        }

        public static async Task<Uri> agregarCarta(Carta2 c)
        {
            var url = "http://localhost:8034/api/carta/" + c.imagenCarta + "/" + c.nombreCarta + "/" + c.valorCarta + "/" + c.idCategoria + "/agregarCarta";
            HttpResponseMessage response = await client.PostAsJsonAsync(url, c);

            return response.Headers.Location;
        }

        #endregion

        #region Buscar
        [HttpPost]
        public ActionResult Buscar(CartaViewModel c)
        {
            try
            {
                //ViewBag.Result1 = categoriaApiClienat.categorias();

                Carta car = new Carta();
                car.idCarta = c.idCarta;

                Carta model = cartaApiController.buscarCarta(car);

                if(model == null)
                {
                    ViewBag.error = "si";
                    ViewBag.error2 = "No se ha encontrado la carta.";
                }
                else
                {
                    ViewBag.error = "no";
                    ViewBag.data = model;
                }
                

                return View();
            }
            catch
            {
                return RedirectToAction("Error");
            }

        }


        #endregion

        #region Exportar pdf
        [HttpPost]
        [ValidateInput(false)]
        public FileResult Export(Carta c)
        {
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(c.Grid);
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Listado-Cartas.pdf");
            }
        }
        #endregion
    }
}