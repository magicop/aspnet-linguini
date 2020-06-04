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
    public class OrdenController : Controller
    {

        private ApiRestful ordenApiController = new ApiRestful();

        #region Listar
        // GET: Orden
        public ActionResult Listar()
        {
            List<Orden> model = ordenApiController.listarOrdenLista();

            ViewBag.data1 = model;

            List<Orden> model2 = ordenApiController.listarOrdenPreparacion();

            ViewBag.data2 = model2;

            List<Orden> model3 = ordenApiController.listarOrdenTerminada(); 

            ViewBag.data4 = model3;

            return View();

        }
        #endregion

        #region Formularios
        public ActionResult FormAgregar()
        {
            return View();
        }

        public ActionResult FormBuscar()
        {
            return View(new OrdenViewModel());
        }
        #endregion

        #region Buscar
        [HttpPost]
        public ActionResult Buscar(Orden c)
        {
            try
            {
                //ViewBag.Result1 = categoriaApiClienat.categorias();

                Orden model = ordenApiController.buscarOrden(c);

                if (model == null)
                {
                    ViewBag.error = "si";
                    ViewBag.error2 = "No se ha encontrado la orden.";
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

        #region ListaPreparacion
        public ActionResult ListaPreparacion(int id)
        {

            ordenApiController.listaPreparacion(id);

            List<Orden> model = ordenApiController.listarOrdenLista();

            ViewBag.data1 = model;

            List<Orden> model2 = ordenApiController.listarOrdenPreparacion();

            ViewBag.data2 = model2;

            List<Orden> model3 = ordenApiController.listarOrdenTerminada();

            ViewBag.data3 = model3;

            return View("Listar");
        }
        #endregion

        #region PreparacionTerminada
        public ActionResult PreparacionTerminada(int id)
        {

            ordenApiController.preparacionTerminacion(id);

            List<Orden> model = ordenApiController.listarOrdenLista();

            ViewBag.data1 = model;

            List<Orden> model2 = ordenApiController.listarOrdenPreparacion();

            ViewBag.data2 = model2;

            List<Orden> model3 = ordenApiController.listarOrdenTerminada();

            ViewBag.data3 = model3;

            return View("Listar");
        }
        #endregion

        #region Exportar pdf
        [HttpPost]
        [ValidateInput(false)]
        public FileResult Export(Orden c)
        {
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(c.Grid1);
                StringReader sr2 = new StringReader(c.Grid2);
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr2);
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Listado-Ordenes.pdf");
            }
        }
        #endregion
    }
}