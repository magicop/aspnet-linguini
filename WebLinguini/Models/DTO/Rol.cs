using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class Rol
    {

        [JsonProperty("idRol")]
        public int idRol { get; set; }

        [JsonProperty("nombreRol")]
        public string nombreRol { get; set; }
    }
}