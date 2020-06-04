using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class DetalleCarta
    {
        [JsonProperty("idDetalleCarta")]
        public int idDetalleCarta { get; set; }

        [JsonProperty("cantidadProducto")]
        public int cantidadProducto { get; set; }

        [JsonProperty("idCarta")]
        public int idCarta { get; set; }

        [JsonProperty("nombreCartas")]
        public string nombreCartas { get; set; }

        [JsonProperty("idProducto")]
        public int idProducto { get; set; }

        [JsonProperty("nombreProducto")]
        public string nombreProducto { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }
    }
}