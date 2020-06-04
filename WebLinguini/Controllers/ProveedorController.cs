using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLinguini.Models;
using WebLinguini.Models.DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.text.html.simpleparser;
using System.IO;

namespace WebLinguini.Controllers
{
    public class ProveedorController : Controller
    {
        private ApiRestful provApiController = new ApiRestful();

        // GET: Proveedor
        public ActionResult Listar()
        {
            List<Proveedor> model = provApiController.listarProveedores();

            ViewBag.data = model;

            return View();

        }


        #region Formularios

        public ActionResult FormBuscar()
        {
            return View(new Proveedor());
        }
        #endregion

        #region Buscar
        [HttpPost]
        public ActionResult Buscar(Proveedor c)
        {
            try
            {
                //ViewBag.Result1 = categoriaApiClienat.categorias();

                Proveedor model = provApiController.buscarProveedor(c);

                if (model == null)
                {
                    ViewBag.error = "si";
                    ViewBag.error2 = "No se ha encontrado el pedido de proveedor.";
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
        public FileResult Export(Proveedor c)
        {
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(c.Grid);
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Listado-Proveedores.pdf");
            }
        }
        #endregion
    }
}