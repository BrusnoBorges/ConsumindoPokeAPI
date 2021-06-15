using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumindoPokeAPI
{
    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int base_experience { get; set; }
        public string height { get; set; }
        public bool is_default { get; set; }
        public int order { get; set; }
        public int weight { get; set; }

    }
}
 