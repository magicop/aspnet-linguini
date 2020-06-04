using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.DTO
{
    public class Proveedor
    {
        [JsonProperty("idProveedor")]
        public int idProveedor { get; set; }

        [JsonProperty("direccionProveedor")]
        public string direccionProveedor { get; set; }

        [JsonProperty("nombreProveedor")]
        public string nombreProveedor { get; set; }

        [JsonProperty("rutProveedor")]
        public string rutProveedor { get; set; }

        [JsonProperty("telefonoProveedor")]
        public string telefonoProveedor { get; set; }

        [JsonProperty("LstProveedores")]
        public SelectList LstProveedores { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }

        /*#region Constructor para inicializar el combobox
        public Proveedor()
        {
            var _rest = new ApiRestful();
            var lstInfo = _rest.listarProveedores();
            LstProveedores = new SelectList(lstInfo, "idProveedor", "nombreProveedor");

        }
        #endregion*/
    }
}