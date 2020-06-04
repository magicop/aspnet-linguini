using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.DTO
{
    public class SolicitudProveedor
    {
        [JsonProperty("idSolicitudProveedor")]
        public int idSolicitudProveedor { get; set; }

        [JsonProperty("cantidadSolicitud")]
        public int cantidadSolicitud { get; set; }

        [JsonProperty("ordenCompra")]
        public int ordenCompra { get; set; }

        [JsonProperty("valorDetalleSolicitud")]
        public int valorDetalleSolicitud { get; set; }

        [JsonProperty("nombreEmpleado")]
        public string nombreEmpleado { get; set; }

        [JsonProperty("idEmpleado")]
        public int idEmpleado { get; set; }

        [JsonProperty("idProducto")]
        public int idProducto { get; set; }

        [JsonProperty("idProveedor")]
        public int idProveedor { get; set; }

        [JsonProperty("nombreProducto")]
        public string nombreProducto { get; set; }

        [JsonProperty("nombreProveedor")]
        public string nombreProveedor { get; set; }

        [JsonProperty("LstSolProv")]
        public SelectList LstSolProv { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }

        /*#region Constructor para inicializar el combobox
        public SolicitudProveedor()
        {
            var _rest = new ApiRestful();
            var lstInfo = _rest.listarSolicitudProveedores(); // Listar Meseros va
            LstSolProv = new SelectList(lstInfo, "idSolicitudProveedor", "idSolicitudProveedor");

        }
        #endregion*/
    }
}