using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class DetalleComprobante
    {
        [JsonProperty("idDetalleComprobante")]
        public int idDetalleComprobante { get; set; }

        [JsonProperty("cantidad_Orden")]
        public int cantidad_Orden { get; set; }

        [JsonProperty("precioDetalleComprobante")]
        public int precioDetalleComprobante { get; set; }

        [JsonProperty("idCarta")]
        public int idCarta { get; set; }

        [JsonProperty("idComprobante")]
        public int idComprobante { get; set; }
    }
}