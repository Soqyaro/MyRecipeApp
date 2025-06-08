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

        public Recipe NewRecipe;

        public AddRecipeForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //считываем введенные пользователем данные из полей
            string name = textBoxName.Text.Trim();//убираем пробелы по бокам с Trim()
            string ingredients = textBoxIngredients.Text.Trim();//если они есть
            string instructions = textBoxInstructions.Text.Trim();

            //проверка на пустоту полей при добавлении нового рецепта
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ingredients) || string.IsNullOrEmpty(instructions))
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед добавлением нового рецепта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //выход из обработчика, рецепт не добавится, форма не закроется
            }

            NewRecipe = new Recipe(name, ingredients, instructions);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
