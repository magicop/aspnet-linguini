using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class Log
    {
        [JsonProperty("idLog")]
        public int idLog { get; set; }

        [JsonProperty("descripcionLog")]
        public string descripcionLog { get; set; }

        [JsonProperty("tipoLog")]
        public string tipoLog { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }
    }
}