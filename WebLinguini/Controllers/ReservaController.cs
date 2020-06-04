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
    public class ReservaController : Controller
    {

        private ApiRestful reservaApiClient = new ApiRestful();
        static HttpClient client = new HttpClient();

        // GET: Reserva
        public ActionResult Listar()
        {

            //ViewBag.Result1 = categoriaApiClient.categorias();

            List<Reservas> model = reservaApiClient.listarReservas();

            ViewBag.data = model;

            return View();
        }

        #region Exportar pdf
        [HttpPost]
        [ValidateInput(false)]
        public FileResult Export(Reservas c)
        {
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(c.Grid);
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Listado-Reservas.pdf");
            }
        }
        #endregion


    }
}