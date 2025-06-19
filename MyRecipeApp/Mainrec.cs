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
        //private bool suppressSelectionEvent = false;
        private string currentFilePath = null;

        public Mainrec()
        {
            InitializeComponent();
            recipeBook = new RecipeBook();
            RefreshRecipeList();//ADDED:сразу задизейблил кнопки, пока список пуст
        }

        //Обновление ListBox
        private void RefreshRecipeList()
        {
            //ADDED:suppressSelectionEvent = true; откл реакцию листбокса
            int selectedIndex = listBoxRecipes.SelectedIndex;
            listBoxRecipes.Items.Clear(); //очищаем текущий список
                                         
            foreach (Recipe recipe in recipeBook.GetAllRecipes())
            {
                listBoxRecipes.Items.Add(recipe);//добавляем рецепт из книги в ListBox
            }

            if(selectedIndex >= 0 && selectedIndex < listBoxRecipes.Items.Count)
            {
                listBoxRecipes.SelectedIndex = selectedIndex;
            }

            bool hasItem = listBoxRecipes.Items.Count > 0; //проверяем есть ли элементы в ListBox
            bool hasSelection = listBoxRecipes.SelectedItem != null; //проверяем есть ли выделенный элемент

            buttonSave.Enabled = hasItem; //включаем кнопки только если есть элементы в списке
            buttonRemove.Enabled = hasSelection; //включаем кнопку удаления только если есть выделенный элемент

            //ADDED:suppressSelectionEvent = false;

            /*включаем/отключаем кнопки в зависимости от наличия рецептов
            //bool hasAny = listBoxRecipes.Items.Count > 0; //тру если в ЛБ что-то есть
            //buttonSave.Enabled = hasAny; //можно сохранить только если есть что сохранять
            //buttonRemove.Enabled = hasAny; //удалять тоже нечего, если нет рецептов*/
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
            //получаем выделенный элемент в ListBox
            Recipe selectedRecipe = listBoxRecipes.SelectedItem as Recipe;
            //MessageBox.Show(selectedRecipe.ToString());
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
                //На данный момент невывполнимое условие, тк теперь эта кнопка не работает при пустом листбоксе
            }
      
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Открываем диалог для выбора файла сохранения
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON файлы (*.json)|*.json|Все файлы (*.*)|*.*";
            saveFileDialog.Title = "Сохранить рецепты в файл";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //добавил карент файл пас
                currentFilePath = saveFileDialog.FileName;
                //сохраняем рецепты в выбранный файл
                recipeBook.SaveToFile(currentFilePath);
                MessageBox.Show("Рецепт успешно сохранен.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //открываем диалог для выбора файла загрузки
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON файлы (*.json)|*.json|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Загрузить рецепты из файла";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //добавил карент файл пас
                currentFilePath = openFileDialog.FileName;

                
                bool hasRecipes = recipeBook.LoadFromFile(currentFilePath); //тянем из RecipeBook.cs - LoadFromFile

                //обновляем список на форме
                RefreshRecipeList();

                if(hasRecipes)
                {
                    //загружаем рецепты из выбранного файла
                    MessageBox.Show("Рецепт успешно загружен.", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Файл пуст. Рецепт не загружен.", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
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
        private void listBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bool hasSelection = listBoxRecipes.SelectedIndex >= 0;
            //buttonRemove.Enabled = hasSelection; //удалять только если выбран рецепт
            //buttonSave.Enabled = hasSelection; //сохранять только если выбран рецепт
            buttonRemove.Enabled = listBoxRecipes.SelectedItem != null; //включаем кнопку удаления только если есть выделенный элемент
        }

        private void ReftegLabel_Click(object sender, EventArgs e)
        {
            TheReference refForm = new TheReference();
            this.Hide();
            refForm.ShowDialog();
            this.Show();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit(); //выход из приложения
        }
    }
}
