using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.ViewModel
{
    public class DetalleCartaViewModel
    {
        [JsonProperty("LstDetalleCartas")]
        public SelectList LstDetalleCartas { get; set; }

        [JsonProperty("LstProductos")]
        public SelectList LstProductos { get; set; }

        [JsonProperty("idDetalleCarta")]
        public int idDetalleCarta { get; set; }

        [JsonProperty("idCarta")]
        public int idCarta { get; set; }

        [JsonProperty("idProducto")]
        public int idProducto { get; set; }

        [JsonProperty("nombreCarta")]
        public string nombreCarta { get; set; }

        [JsonProperty("nombreProducto")]
        public string nombreProducto { get; set; }

        [JsonProperty("cantidadProducto")]
        public int cantidadProducto { get; set; }


        #region Constructor para inicializar el combobox
        public DetalleCartaViewModel()
        {
            var _rest = new ApiRestful();
            var lstInfo = _rest.listarCartas();
            LstDetalleCartas = new SelectList(lstInfo, "idCarta", "nombreCarta");

            var lstInfo2 = _rest.listarProductos();
            LstProductos = new SelectList(lstInfo2, "idProducto", "nombreProducto");



        }
        #endregion
    }
}