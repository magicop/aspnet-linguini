using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class Bodega
    {
        [JsonProperty("idBodega")]
        public int idBodega { get; set; }

        [JsonProperty("idEmpleado")]
        public int idEmpleado { get; set; }

        [JsonProperty("nombreBodega")]
        public string nombreBodega { get; set; }

        [JsonProperty("idSucursal")]
        public int idSucursal { get; set; }
    }
}