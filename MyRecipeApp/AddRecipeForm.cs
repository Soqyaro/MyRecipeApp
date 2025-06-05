using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyRecipeApp
{
    public partial class AddRecipeForm : Form
    {

        public Recipe NewRecipe; // Свойство для хранения нового рецепта

        public AddRecipeForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Считываем введенные пользователем данные из полей
            string name = textBoxName.Text;                 // название рецепта
            string ingredients = textBoxIngredients.Text;   // ингредиенты
            string instructions = textBoxInstructions.Text; // инструкция

            // Создаем объект Recipe с введенными данными
            NewRecipe = new Recipe(name, ingredients, instructions);

            this.DialogResult = DialogResult.OK; // устанавливаем результат диалога как OK
            this.Close(); // закрываем форму
        }
    }
}
