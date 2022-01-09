using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokemonAPI.Interfaces;
using PokemonAPI.Models;
using PokemonAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PokemonAPI.Controllers
{
    [Route("api/pokemonController")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pokemon1 = new Pokemon
            {
                Id = 1,
                Name = "Bulbasaur",
                Region = "Sinnoh",
                Type = new List<string> { "Grass" }
            };
            return StatusCode((int)HttpStatusCode.OK, pokemon1);

            // return StatusCode((int)HttpStatusCode.OK, _pokemonService.GetPokemon());
         
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
