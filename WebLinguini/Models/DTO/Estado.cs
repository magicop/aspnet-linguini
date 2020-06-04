using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class Estado
    {
        [JsonProperty("idEstado")]
        public int idEstado { get; set; }

        [JsonProperty("nombreEstado")]
        public string nombreEstado { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }
    }
}