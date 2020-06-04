using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.DTO
{
    public class Carta
    {

        [JsonProperty("idCarta")]
        public int idCarta { get; set; }

        [JsonProperty("imagenCarta")]
        public string imagenCarta { get; set; }

        [JsonProperty("nombreCarta")]
        public string nombreCarta { get; set; }

        [JsonProperty("valorCarta")]
        public int valorCarta { get; set; }

        [JsonProperty("idCategoria")]
        public int idCategoria { get; set; }

        [JsonProperty("nombreCategoria")]
        public string nombreCategoria { get; set; }

        public SelectList nombreCategoria2 { get; set; }

        [JsonProperty("idProducto1")]
        public int idProducto1 { get; set; }

        [JsonProperty("nombreProducto1")]
        public string nombreProducto1 { get; set; }

        public SelectList LstProductos { get; set; }

        [JsonProperty("cantidadProducto1")]
        public string cantidadProducto1 { get; set; }

        [JsonProperty("idProducto2")]
        public int idProducto2 { get; set; }

        [JsonProperty("nombreProducto2")]
        public string nombreProducto2 { get; set; }

        [JsonProperty("cantidadProducto2")]
        public string cantidadProducto2 { get; set; }

        [JsonProperty("LstCartas")]
        public SelectList LstCartas { get; set; }

        [JsonProperty("Grid")]
        public string Grid { get; set; }

        #region Constructor para inicializar el combobox
        public Carta()
        {
            var _rest = new ApiRestful();
            var lstInfo = _rest.listarCategorias();
            nombreCategoria2 = new SelectList(lstInfo, "idCategoria", "nombreCategoria");

            var lstInfo2 = _rest.listarProductos();
            LstProductos = new SelectList(lstInfo2, "idProducto", "nombreProducto");

            var lstInfo3 = _rest.listarCartas();
            LstCartas = new SelectList(lstInfo2, "idCarta", "nombreCarta");

        }
        #endregion

    }
}