using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.DTO
{
    public class Producto
    {
        [JsonProperty("idProducto")]
        public int idProducto { get; set; }

        [JsonProperty("nombreProducto")]
        public string nombreProducto { get; set; }

        [JsonProperty("nombreCategoria")]
        public string nombreCategoria { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }

    }
}