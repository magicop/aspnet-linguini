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
    public class PedidoProveedorController : Controller
    {
        private ApiRestful pedprovApiController = new ApiRestful();
        static HttpClient client = new HttpClient();

        #region Listar
        // GET: PedidoProveedor
        public ActionResult Listar()
        {
            List<PedidoProveedor> model = pedprovApiController.listarPedidosProveedores();

            ViewBag.data = model;

            return View();

        }
        #endregion

        #region Formularios
        public ActionResult FormBuscar()
        {
            return View(new PedidoProveedor());
        }

        public ActionResult FormAgregar()
        {
            return View(new PedProvViewModel());
        }
        #endregion

        #region Agregar
        [HttpPost]

        public async Task<ActionResult> Agregar(PedProvViewModel c)
        {
            try
            {
                //ViewBag.Result1 = categoriaApiClienat.categorias();
                SolicitudProveedor p = new SolicitudProveedor();

                p.idEmpleado = c.idEmpleado;
                p.idProducto = c.idProducto;
                p.idProveedor = c.idProveedor;
                p.cantidadSolicitud = c.cantidadSolicitud;
                p.valorDetalleSolicitud = c.valorDetalleSolicitud;
                p.ordenCompra = c.ordenCompra;

                PedidoProveedor pe = new PedidoProveedor();
                pe.ordenCompra = c.ordenCompra;

                var result = await agregarPedidoProv(p);

                ViewBag.ok = "si";
                ViewBag.mensaje = "Su pedido ha sido agregado con éxito.";

                return View("FormAgregar", new PedProvViewModel());
            }
            catch
            {
                return RedirectToAction("Error");
            }

        }

        public static async Task<Uri> agregarPedidoProv(SolicitudProveedor c)
        {
            var url = "http://localhost:8034/api/solicitudProveedor/" + c.cantidadSolicitud + "/" + c.ordenCompra + "/" + c.valorDetalleSolicitud + "/" + c.idEmpleado + "/" + c.idProducto + "/" + c.idProveedor + "/agregarSolicitudProveedor";
            HttpResponseMessage response = await client.PostAsJsonAsync(url, c);
            return response.Headers.Location;
        }

        #endregion

        #region Buscar
        [HttpPost]
        public ActionResult Buscar(PedidoProveedor c)
        {
            try
            {
                //ViewBag.Result1 = categoriaApiClienat.categorias();

                PedidoProveedor model = pedprovApiController.buscarPedProvPorOrdenCompra(c);

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

        #region CambiarOrden

        [HttpPost]

        public async Task<ActionResult> CambiarOrden(PedProvViewModel c)
        {
            try
            {
                //ViewBag.Result1 = categoriaApiClienat.categorias();

                var result = await cambiarOrden();


                return View("FormAgregar", new PedProvViewModel());
            }
            catch
            {
                return RedirectToAction("Error");
            }

        }

        public static async Task<Uri> cambiarOrden()
        {
            var url = "http://localhost:8034/api/solicitudProveedor/ultimaOrdenCompra";
            HttpResponseMessage response = await client.GetAsync(url);
            return response.Headers.Location;
        }
        #endregion

        #region Recibir Pedido
        public ActionResult RecibirPedido(int id)
        {
            pedprovApiController.recibirPedido(id);

            List<PedidoProveedor> model = pedprovApiController.listarPedidosProveedores();

            ViewBag.data = model;

            return View("Listar");
        }
        #endregion

        #region Exportar pdf
        [HttpPost]
        [ValidateInput(false)]
        public FileResult Export(PedidoProveedor c)
        {
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                try
                {
                    StringReader sr = new StringReader(c.Grid);
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    pdfDoc.Close();
                    return File(stream.ToArray(), "application/pdf", "Listado-PedidoProvs.pdf");
                }
                catch
                {

                    return null;
                }
                
            }
        }
        #endregion

    }
}