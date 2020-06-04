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

namespace WebLinguini.Controllers
{
    public class MesaController : Controller
    {
        private ApiRestful mesaApiController = new ApiRestful();

        // GET: Mesa
        public ActionResult Listar()
        {
            List<Mesa> model = mesaApiController.listarMesas();

            ViewBag.data = model;

            return View(new Mesa());
        }

        #region Formularios
        public ActionResult FormAgregar()
        {
            return View(new Mesa());
        }

        public ActionResult FormBuscar()
        {
            return View(new MesaViewModel());
        }
        #endregion

        #region Buscar
        [HttpPost]
        public ActionResult Buscar(Mesa c)
        {
            try
            {
                //ViewBag.Result1 = categoriaApiClienat.categorias();

                Mesa model = mesaApiController.buscarMesa(c);

                if (model == null)
                {
                    ViewBag.error = "si";
                    ViewBag.error2 = "No se ha encontrado la mesa.";
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
        public FileResult Export(Mesa c)
        {
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(c.Grid);
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Listado-Mesas.pdf");
            }
        }
        #endregion

    }
}