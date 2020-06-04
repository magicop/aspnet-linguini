using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class Cliente
    {
        [JsonProperty("rutCliente")]
        public string rutCliente { get; set; }

        [JsonProperty("apMaternoCliente")]
        public string apMaternoCliente { get; set; }

        [JsonProperty("apPaternoCliente")]
        public string apPaternoCliente { get; set; }

        [JsonProperty("nombreCliente")]
        public string nombreCliente { get; set; }

        [JsonProperty("telefonoCliente")]
        public string telefonoCliente { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }
    }
}