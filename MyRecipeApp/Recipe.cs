using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeApp
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }

        public Recipe(string name, string ingredients, string instructions)
        {
            Name = name;
            Ingredients = ingredients;
            Instructions = instructions;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
