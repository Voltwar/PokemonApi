using System;
using System.Collections.Generic;
using PokemonAPI.Interfaces;
using PokemonAPI.Models;

namespace PokemonAPI.Services
{
    public class PokemonService : IPokemonService
    {
        public new Pokemon GetPokemon()
        {
            return new Pokemon
            {
                Id = 1,
                Name = "Bulbasaur",
                Region = "Sinnoh",
                Type = new List<string>{"Grass"}
            };
        }
    }
}
