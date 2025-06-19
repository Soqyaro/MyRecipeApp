using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeApp
{
    public class Recipe
    {
        public string Name { get; }
        public string Ingredients { get; }
        public string Instructions { get; }

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
