using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.DTO
{
    public class Comprobante
    {
        [JsonProperty("idComprobante")]
        public int idComprobante { get; set; }

        [JsonProperty("fechaEmisionComprobante")]
        public DateTime fechaEmisionComprobante { get; set; }

        [JsonProperty("idOrden")]
        public int idOrden { get; set; }

        [JsonProperty("totalComprobante")]
        public int totalComprobante { get; set; }

        [JsonProperty("idTipoPago")]
        public int idTipoPago { get; set; }

        [JsonProperty("nombreTipoPago")]
        public string nombreTipoPago { get; set; }

        [JsonProperty("idMesa")]
        public int idMesa { get; set; }

        [JsonProperty("descripcionTipoPago")]
        public string descripcionTipoPago { get; set; }

        [JsonProperty("LstComprobantes")]
        public SelectList LstTipoPagos { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }

        #region Constructor para inicializar el combobox
        public Comprobante()
        {
            var _rest = new ApiRestful();
            var lstInfo = _rest.listarTipoPagos();
            LstTipoPagos = new SelectList(lstInfo, "idTipoPago", "descripcionTipoPago");

        }
        #endregion
    }
}