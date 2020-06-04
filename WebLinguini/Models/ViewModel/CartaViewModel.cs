using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.ViewModel
{
    public class CartaViewModel
    {
        [JsonProperty("LstCartas")]
        public SelectList LstCartas { get; set; }

        [JsonProperty("idCarta")]
        public int idCarta { get; set; }

        [JsonProperty("nombreCarta")]
        public int nombreCarta { get; set; }

        #region Constructor para inicializar el combobox
        public CartaViewModel()
        {
            var _rest = new ApiRestful();
            var lstInfo = _rest.listarCartas();
            LstCartas = new SelectList(lstInfo, "idCarta", "nombreCarta");

        }
        #endregion
    }
}