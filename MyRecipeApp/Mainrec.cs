using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRecipeApp
{
    public partial class Mainrec : Form
    {

        private RecipeBook recipeBook;

        public Mainrec()
        {
            InitializeComponent();
            recipeBook = new RecipeBook(); //инициализируем книгу рецептов
        }

        //Обновляет содержимое ListBox на форме
        private void RefreshRecipeList()
        {
            listBoxRecipes.Items.Clear(); // очищаем текущий список на форме
                                         // Добавляем каждый рецепт из книги в ListBox
            foreach (Recipe recipe in recipeBook.GetAllRecipes())
            {
                listBoxRecipes.Items.Add(recipe); // добавляем объект Recipe; вызовется его ToString()
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Создаем и показываем форму добавления рецепта
            AddRecipeForm addForm = new AddRecipeForm();
            if (addForm.ShowDialog() == DialogResult.OK) // если пользователь нажал OK
            {
                // Извлекаем созданный рецепт из формы
                Recipe newRecipe = addForm.NewRecipe;
                // Добавляем рецепт в книгу
                recipeBook.AddRecipe(newRecipe);
                // Обновляем отображение списка рецептов
                RefreshRecipeList();
            }
            // Если пользователь нажал Отмена, просто ничего не делаем
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Получаем выделенный элемент в ListBox
            Recipe selectedRecipe = listBoxRecipes.SelectedItem as Recipe;
            if (selectedRecipe != null)
            {
                // Удаляем его из книги рецептов
                recipeBook.RemoveRecipe(selectedRecipe);
                // Обновляем список
                RefreshRecipeList();
            }
            else
            {
                // Если ничего не выбрано, можно показать сообщение (опционально)
                MessageBox.Show("Пожалуйста, выберите рецепт для удаления.",
                                "Удалить рецепт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Открываем диалог для выбора файла сохранения
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.Title = "Сохранить рецепты в файл";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Сохраняем рецепты в выбранный файл
                recipeBook.SaveToFile(saveFileDialog.FileName);
                MessageBox.Show("Рецепты успешно сохранены.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // Открываем диалог для выбора файла загрузки
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Загрузить рецепты из файла";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Загружаем рецепты из выбранного файла
                recipeBook.LoadFromFile(openFileDialog.FileName);
                // Обновляем список на форме
                RefreshRecipeList();
                MessageBox.Show("Рецепты успешно загружены.", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void recipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recipe selectedRecipe = listBoxRecipes.SelectedItem as Recipe;
            if (selectedRecipe != null && selectedRecipe.)
            {
                MessageBox.Show(
                    $"Название: {selectedRecipe.Name}\n\nИнгредиенты:\n{selectedRecipe.Ingredients}\n\nИнструкция:\n{selectedRecipe.Instructions}",
                    "Подробности рецепта",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

    }
}
