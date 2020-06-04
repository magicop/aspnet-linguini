using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLinguini.Models.DTO
{
    #region LlenarCategorias
    public class LlenarCategorias
    {
        public int idCategoria { get; set; }
        public string descripcionCategoria { get; set; }

        public SelectList lstCategorias { get; set; }
    }
    #endregion

    
}