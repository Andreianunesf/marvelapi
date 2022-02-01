﻿using System.Collections.Generic;

namespace MarvelMasterApi.Models.Serialization
{
    public class Data
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<Character> results { get; set; }
    }
}
