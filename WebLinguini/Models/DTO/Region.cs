using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLinguini.Models.DTO
{
    public class Region
    {
        [JsonProperty("idRegion")]
        public int idRegion { get; set; }

        [JsonProperty("nombreRegion")]
        public string nombreRegion { get; set; }
    }
}