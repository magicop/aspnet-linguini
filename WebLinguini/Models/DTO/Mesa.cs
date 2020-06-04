using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.DTO
{
    public class Mesa
    {
        [JsonProperty("idMesa")]
        public int idMesa { get; set; }

        [JsonProperty("cantidadPersonas")]
        public int cantidadPersonas { get; set; }

        [JsonProperty("idEmpleado")]
        public int idEmpleado { get; set; }

        [JsonProperty("nombreEmpleado")]
        public string nombreEmpleado { get; set; }

        [JsonProperty("nombreEstado")]
        public string nombreEstado { get; set; }

        [JsonProperty("LstEmpleados")]
        public SelectList LstEmpleados { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }


        #region Constructor para inicializar el combobox
        public Mesa()
        {
            var _rest = new ApiRestful();
            var lstInfo = _rest.listarEmpleados(); // Listar Meseros va
            LstEmpleados = new SelectList(lstInfo, "idEmpleado", "nombreEmpleado");

        }
        #endregion
    }
}