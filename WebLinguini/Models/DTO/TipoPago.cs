using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class TipoPago
    {
        [JsonProperty("idTipoPago")]
        public int idTipoPago { get; set; }

        [JsonProperty("descripcionTipoPago")]
        public string descripcionTipoPago { get; set; }

    }
}