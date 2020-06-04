using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.DTO
{
    public class ListaModel
    {
        public string idCategoria { get; set; }
        public SelectList LstCategorias { get; set; }

        public ListaModel()
        {
            var apiLista = new ApiRestful();

            var lstCategorias = apiLista.listarCategorias();
            LstCategorias = new SelectList(lstCategorias, "idCategoria", "nombreCategoria");
        }
    }


}