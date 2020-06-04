using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class Ciudad
    {
        [JsonProperty("idCiudad")]
        public int idCiudad { get; set; }

        [JsonProperty("nombreCiudad")]
        public string nombreCiudad { get; set; }

        [JsonProperty("idRegion")]
        public int idRegion { get; set; }
    }
}