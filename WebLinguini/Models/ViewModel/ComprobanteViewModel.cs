using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.ViewModel
{
    public class ComprobanteViewModel
    {
        [JsonProperty("LstComprobantes")]
        public SelectList LstComprobantes { get; set; }

        [JsonProperty("idComprobante")]
        public int idComprobante { get; set; }

        #region Constructor para inicializar el combobox
        public ComprobanteViewModel()
        {
            var _rest = new ApiRestful();
            var lstInfo = _rest.listarComprobantes();
            LstComprobantes = new SelectList(lstInfo, "idComprobante", "idComprobante");

        }
        #endregion
    }
}