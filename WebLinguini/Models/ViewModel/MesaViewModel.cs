using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.ViewModel
{
    public class MesaViewModel
    {
        [JsonProperty("LstMesas")]
        public SelectList LstMesas { get; set; }

        [JsonProperty("idMesa")]
        public int idMesa { get; set; }

        #region Constructor para inicializar el combobox
        public MesaViewModel()
        {
            var _rest = new ApiRestful();
            var lstInfo = _rest.listarMesas();
            LstMesas = new SelectList(lstInfo, "idMesa", "idMesa");

        }
        #endregion
    }
}