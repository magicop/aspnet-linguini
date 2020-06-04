using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class Empleado
    {
        [JsonProperty("idEmpleado")]
        public int idEmpleado { get; set; }

        [JsonProperty("apMaternoEmpleado")]
        public string apMaternoEmpleado { get; set; }

        [JsonProperty("apPaternoEmpleado")]
        public string apPaternoEmpleado { get; set; }

        [JsonProperty("direccionEmpleado")]
        public string direccionEmpleado { get; set; }

        [JsonProperty("nombreEmpleado")]
        public string nombreEmpleado { get; set; }

        [JsonProperty("rutEmpleado")]
        public string rutEmpleado { get; set; }

        [JsonProperty("telefonoEmpleado")]
        public string telefonoEmpleado { get; set; }

        [JsonProperty("usuarios")]
        public string usuarios { get; set; }

        [JsonProperty("rol")]
        public string rol { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }
    }
}