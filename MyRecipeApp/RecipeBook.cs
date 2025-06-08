using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeApp
{
    public class RecipeBook
    {
        //Список рецептов
        private List<Recipe> recipes;

        public RecipeBook()
        {
            recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)//метод для добавления рецепта в список
        {
            recipes.Add(recipe);//добавляем новый рецепт в список
        }

        
        public void RemoveRecipe(Recipe recipe)//метод для удаления рецепта из списка
        {
            recipes.Remove(recipe);//удаляем рецепт из списка
        }

        
        public List<Recipe> GetAllRecipes()//метод для получения всех рецептов
        {
            return recipes;//возвращаем ссылку на список рецептов
        }

        
        public void SaveToFile(string filePath)//метод для сохранения всех рецептов в .txt файл
        {
            //открываем файл на запись
            using (StreamWriter sw = new StreamWriter(filePath))//автозакроется
            {
                foreach (Recipe recipe in recipes)
                {
                    //формирование строки с разделиелем
                    string line = recipe.Name + "|" + recipe.Ingredients + "|" + recipe.Instructions;
                    sw.WriteLine(line); //записываем строку в файл
                }
            } 
        }

        public void LoadFromFile(string filePath)//метод для загрузки рецептов из текстового файла
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                recipes.Clear(); //очищаем текущий список перед загрузкой
                string line;
                //считываем файл построчно
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    
                    if (parts.Length >= 3)//условие 3 частей
                    {
                        //делаем новый объект Recipe, добавляем в список
                        Recipe recipe = new Recipe(parts[0], parts[1], parts[2]);
                        recipes.Add(recipe);
                    }
                    //строка не учитыве
                }
            } 
        }
    }

}
