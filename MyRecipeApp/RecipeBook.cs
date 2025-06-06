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

        // метод для добавления рецепта в список
        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe); // добавляем новый рецепт в список
        }

        //Метод для удаления рецепта из списка
        public void RemoveRecipe(Recipe recipe)
        {
            recipes.Remove(recipe); // удаляем рецепт из списка
        }

        // метод для получения всех рецептов
        public List<Recipe> GetAllRecipes()
        {
            return recipes; // возвращаем ссылку на список рецептов
        }

        //Метод для сохранения всех рецептов в текстовый файл
        public void SaveToFile(string filePath)
        {
            //Открываем файл на запись
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Записываем каждый рецепт форматируя по |,  "Название|Ингредиенты|Инструкция"
                foreach (Recipe recipe in recipes)
                {
                    // Формирование строки: поля разделены символом '|'
                    string line = recipe.Name + "|" + recipe.Ingredients + "|" + recipe.Instructions;
                    sw.WriteLine(line); // записываем строку в файл
                }
            } //файл автоматически закрывается после выхода из блока using
        }

        //Метод для загрузки рецептов из текстового файла
        public void LoadFromFile(string filePath)
        {
            // Открываем файл на чтение
            using (StreamReader sr = new StreamReader(filePath))
            {
                recipes.Clear(); // очищаем текущий список рецептов перед загрузкой
                string line;
                // считываем файл построчно
                while ((line = sr.ReadLine()) != null)
                {
                    // Разбиваем строку по символу | на части
                    string[] parts = line.Split('|');
                    // Ожидаем, что строка имеет три части: название, ингредиенты, инструкция
                    if (parts.Length >= 3)
                    {
                        // Создаем новый объект Recipe и добавляем в список
                        Recipe recipe = new Recipe(parts[0], parts[1], parts[2]);
                        recipes.Add(recipe);
                    }
                    // Если формат строки некорректен (меньше 3 частей), то такую строку пропускаем
                }
            } // файл автоматически закрывается
        }
    }

}
