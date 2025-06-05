using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeApp
{
    public class Recipe
    {
        public string Name;//Название рецепта
        public string Ingredients; //Ингредиенты
        public string Instructions; //Инструкции по приготовлению

        public Recipe(string name, string ingredients, string instructions)
        {
            Name = name;
            Ingredients = ingredients;
            Instructions = instructions;
        }

        public override string ToString()
        {
            return Name; //возвращаем название рецепта
        }
    }
}
