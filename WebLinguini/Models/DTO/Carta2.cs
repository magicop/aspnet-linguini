using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.DTO
{
    public class Carta2
    {
        [JsonProperty("idCarta")]
        public int idCarta { get; set; }

        [JsonProperty("imagenCarta")]
        public string imagenCarta { get; set; }

        [JsonProperty("nombreCarta")]
        public string nombreCarta { get; set; }

        [JsonProperty("valorCarta")]
        public int valorCarta { get; set; }

        [JsonProperty("idCategoria")]
        public int idCategoria { get; set; }

        [JsonProperty("nombreCategoria")]
        public string nombreCategoria { get; set; }


    }
}