// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using System;
using System.Collections.Generic;

namespace MarvelMasterApi.Models.Serialization

{
    public class Thumbnail
    {
        public string path { get; set; }
        public string extension { get; set; }
    }
}
