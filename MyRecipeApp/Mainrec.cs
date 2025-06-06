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
        private bool suppressSelectionEvent = false;
        private string currentFilePath = null;

        public Mainrec()
        {
            InitializeComponent();
            recipeBook = new RecipeBook(); 
        }

        //Обновление ListBox
        private void RefreshRecipeList()
        {
            suppressSelectionEvent = true;//откл реакцию листбокса 
            listBoxRecipes.Items.Clear(); //очищаем текущий список
                                         //добавляем рецепт из книги в ListBox
            foreach (Recipe recipe in recipeBook.GetAllRecipes())
            {
                listBoxRecipes.Items.Add(recipe);
            }
            suppressSelectionEvent = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //создаем и показываем форму добавления рецепта
            AddRecipeForm addForm = new AddRecipeForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                //Извлекаем созданный(сущ) рецепт из формы
                Recipe newRecipe = addForm.NewRecipe;
                //Добавляем рецепт в книгу
                recipeBook.AddRecipe(newRecipe);
                //обновляем отображение списка рецептов
                RefreshRecipeList();
            }
            //если пользователь нажал Отмена ниче не делаем
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //Получаем выделенный элемент в ListBox
            Recipe selectedRecipe = listBoxRecipes.SelectedItem as Recipe;
            if (selectedRecipe != null)
            {
                //удаляем его из книги рецептов
                recipeBook.RemoveRecipe(selectedRecipe);
                //обновляем список
                RefreshRecipeList();

                //Добавил
                if(!string.IsNullOrEmpty(currentFilePath))
                {
                    recipeBook.SaveToFile(currentFilePath);
                }
            }
            else
            {
                //если ничего не выбрано
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
                //добавил карент файл пас
                currentFilePath = saveFileDialog.FileName;
                // Сохраняем рецепты в выбранный файл
                recipeBook.SaveToFile(currentFilePath);
                MessageBox.Show("Рецепты успешно сохранены.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //открываем диалог для выбора файла загрузки
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Загрузить рецепты из файла";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //добавил карент файл пас
                currentFilePath = openFileDialog.FileName;
                //загружаем рецепты из выбранного файла
                recipeBook.LoadFromFile(currentFilePath);
                //обновляем список на форме
                RefreshRecipeList();
                MessageBox.Show("Рецепты успешно загружены.", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Добавил
            
            recipeBook.LoadFromFile(currentFilePath);
        }

        private void listBoxRecipes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxRecipes.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                Recipe selectedRecipe = listBoxRecipes.Items[index] as Recipe;
                if (selectedRecipe != null)
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
}
