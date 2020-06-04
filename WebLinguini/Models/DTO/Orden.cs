using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.DTO
{
    public class Orden
    {
        

        [JsonProperty("idOrden")]
        public int idOrden { get; set; }

        [JsonProperty("idMesa")]
        public int idMesa { get; set; }

        [JsonProperty("fechaEmisionOrden")]
        public string fechaEmisionOrden { get; set; }

        [JsonProperty("nombreEstado")]
        public string nombreEstado { get; set; }

        [JsonProperty("imagenCarta")]
        public string imagenCarta { get; set; }

        [JsonProperty("nombreCarta")]
        public string nombreCarta { get; set; }

        [JsonProperty("LstOrdenes")]
        public SelectList LstOrdenes { get; set; }

        [JsonProperty("Grid1")]
        public string Grid1 { get; set; }

        [JsonProperty("Grid2")]
        public string Grid2 { get; set; }

        #region Constructor para inicializar el combobox
        /*public Orden()
        {
            var _rest = new ApiRestful();
            var lstInfo = _rest.listarOrdenes();
            LstOrdenes = new SelectList(lstInfo, "idOrden", "idOrden");

        }*/
        #endregion
    }


}