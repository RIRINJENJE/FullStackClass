using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLaag
{
    public class Ingredient
    {
        public int Id { get; set; }
        // libary is een code van iemand anders die wij gebruiken in onze code

        public string? Name { get; set; }

        public int Amount { get; set; }

        public bool Vegan { get; set; }
    }
}
