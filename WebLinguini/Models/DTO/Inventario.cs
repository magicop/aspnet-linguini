using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class Inventario
    {
        [JsonProperty("idInventario")]
        public int idInventario { get; set; }

        [JsonProperty("nombreBodega")]
        public string nombreBodega { get; set; }

        [JsonProperty("nombreSucursal")]
        public string nombreSucursal { get; set; }

        [JsonProperty("nombreComuna")]
        public string nombreComuna { get; set; }

        [JsonProperty("nombreRegion")]
        public string nombreRegion { get; set; }

        [JsonProperty("nombreCiudad")]
        public string nombreCiudad { get; set; }

        [JsonProperty("nombreProducto")]
        public string nombreProducto { get; set; }

        [JsonProperty("nombreCategoria")]
        public string nombreCategoria { get; set; }

        [JsonProperty("stock")]
        public int stock { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }
    }
}