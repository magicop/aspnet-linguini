using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class Sucursal
    {
        [JsonProperty("idSucursal")]
        public int idSucursal { get; set; }

        [JsonProperty("direccionSucursal")]
        public string direccionSucursal { get; set; }

        [JsonProperty("nombreSucursal")]
        public string nombreSucursal { get; set; }

        [JsonProperty("idComuna")]
        public int idComuna { get; set; }
    }
}