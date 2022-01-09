using System;
using System.Collections.Generic;

namespace PokemonAPI.Models
{
    public class Pokemon
    {
     
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<string> Type { get; set; }
        public string Region { get; set; }
    }
}
