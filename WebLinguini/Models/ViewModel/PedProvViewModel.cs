using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.ViewModel
{
    public class PedProvViewModel
    {
        [JsonProperty("LstEmpleados")]
        public SelectList LstEmpleados { get; set; }

        [JsonProperty("LstProductos")]
        public SelectList LstProductos { get; set; }

        [JsonProperty("LstProveedores")]
        public SelectList LstProveedores { get; set; }

        [JsonProperty("idEmpleado")]
        public int idEmpleado { get; set; }

        [JsonProperty("idProducto")]
        public int idProducto { get; set; }

        [JsonProperty("idProveedor")]
        public int idProveedor { get; set; }

        [JsonProperty("nombreEmpleado")]
        public string nombreEmpleado { get; set; }

        [JsonProperty("nombreProducto")]
        public string nombreProducto { get; set; }

        [JsonProperty("nombreProveedor")]
        public string nombreProveedor { get; set; }

        [JsonProperty("cantidadSolicitud")]
        public int cantidadSolicitud { get; set; }

        [JsonProperty("valorDetalleSolicitud")]
        public int valorDetalleSolicitud { get; set; }

        [JsonProperty("ordenCompra")]
        public int ordenCompra { get; set; }

        #region Constructor para inicializar el combobox
        public PedProvViewModel()
        {
            var _rest = new ApiRestful();
            var lstInfo = _rest.listarAdminBodega();
            LstEmpleados = new SelectList(lstInfo, "idEmpleado", "nombreEmpleado");

            var lstInfo2 = _rest.listarProductos();
            LstProductos = new SelectList(lstInfo2, "idProducto", "nombreProducto");

            var lstInfo3 = _rest.listarProveedores();
            LstProveedores = new SelectList(lstInfo3, "idProveedor", "nombreProveedor");

            var lstInfo4 = _rest.ultimaOrdenCompra();
            ordenCompra = lstInfo4.ordenCompra;            

        }
        #endregion
    }
}