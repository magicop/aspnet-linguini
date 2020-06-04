using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class Caja
    {
        [JsonProperty("idCaja")]
        public int idCaja { get; set; }

        [JsonProperty("descuentoVuelto")]
        public int descuentoVuelto { get; set; }

        [JsonProperty("fecha")]
        public DateTime fecha { get; set; }

        [JsonProperty("ingresoInicialCaja")]
        public int ingresoInicialCaja { get; set; }

        [JsonProperty("sumaTotalComprobante")]
        public int sumaTotalComprobante { get; set; }
    }
}