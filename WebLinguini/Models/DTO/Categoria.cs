using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class Categoria
    {

        [JsonProperty("idCategoria")]
        public int idCategoria { get; set; }

        [JsonProperty("nombreCategoria")]
        public string nombreCategoria { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }
    }


}