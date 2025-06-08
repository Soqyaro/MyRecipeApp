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
            string name = textBoxName.Text;
            string ingredients = textBoxIngredients.Text;
            string instructions = textBoxInstructions.Text;

            NewRecipe = new Recipe(name, ingredients, instructions);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
