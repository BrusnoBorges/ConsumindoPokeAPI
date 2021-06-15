using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoPokeAPI
{
    public class PokeRepositorio
    {

        HttpClient poke = new HttpClient();

        public PokeRepositorio()
        {
            poke.BaseAddress = new Uri("https://pokeapi.co/api/v2/");

            poke.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Pokemon> GetPokeAsync(string iden)
        {

            HttpResponseMessage response = await poke.GetAsync("pokemon/" + iden);

            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Pokemon>(dados);
            }
            return new Pokemon();
        }

    }
}
