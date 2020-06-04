using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.DTO
{
    public class PedidoProveedor
    {
        [JsonProperty("idPedidoProveedor")]
        public int idPedidoProveedor { get; set; }

        [JsonProperty("fechaEmisionSolicitud")]
        public DateTime fechaEmisionSolicitud { get; set; }

        [JsonProperty("fechaEntregaSolicitud")]
        public DateTime fechaEntregaSolicitud { get; set; }

        [JsonProperty("ordenCompra")]
        public int ordenCompra { get; set; }

        [JsonProperty("totalPedidoProveedor")]
        public int totalPedidoProveedor { get; set; }

        [JsonProperty("nombreEmpleado")]
        public string nombreEmpleado { get; set; }

        [JsonProperty("nombreProveedor")]
        public string nombreProveedor { get; set; }

        [JsonProperty("nombreTipoPago")]
        public string nombreTipoPago { get; set; }

        [JsonProperty("nombreEstado")]
        public string nombreEstado { get; set; }

        [JsonProperty("LstPedProv")]
        public SelectList LstPedProv { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }

        /*#region Constructor para inicializar el combobox
        public PedidoProveedor()
        {
            var _rest = new ApiRestful();
            var lstInfo = _rest.listarPedidosProveedores(); // Listar Meseros va
            LstPedProv = new SelectList(lstInfo, "idPedidoProveedor", "idPedidoProveedor");

        }
        #endregion*/

    }
}