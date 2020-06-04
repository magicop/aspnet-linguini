using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.ViewModel
{
    public class OrdenViewModel
    {
        [JsonProperty("LstOrdenes")]
        public SelectList LstOrdenes { get; set; }

        [JsonProperty("idOrden")]
        public int idOrden { get; set; }

        #region Constructor para inicializar el combobox
        public OrdenViewModel()
        {
            var _rest = new ApiRestful();
            var lstInfo = _rest.listarOrdenes();
            LstOrdenes = new SelectList(lstInfo, "idOrden", "idOrden");

        }
        #endregion
    }
}