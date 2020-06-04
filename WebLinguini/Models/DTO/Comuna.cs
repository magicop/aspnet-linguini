using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class Comuna
    {
        [JsonProperty("idComuna")]
        public int idComuna { get; set; }

        [JsonProperty("nombreComuna")]
        public string nombreComuna { get; set; }

        [JsonProperty("idCiudad")]
        public int idCiudad { get; set; }
    }
}