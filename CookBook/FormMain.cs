using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook
{
    //will deal with all the user input and put them to the Recipe object.  And later will put Recipe object to Recipe array created in RecipeManager
    public partial class FormMain : Form
    {
        private const int numOfIngrediens = 50;
        private const int maxNumOfElements = 200;
        Recipe currRecipe = new Recipe(numOfIngrediens);
        RecipeManager recipeMngr = new RecipeManager(maxNumOfElements);


        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        //it initialize begining valuses of GUI
        public void InitializeGUI()
        {
            textBoxNameOfRecipe.Text = string.Empty;
            comboBoxCategory.SelectedIndex = 0;
            textBoxRecipe.Text = string.Empty;
            listBoxRecipes.Text = string.Empty;
        }


        //will control if user put valid data
        private bool CheckInput()
        {
            bool ok = false;
            bool nameOfRecipe = ReadInputNameOfRecipe();
            bool descriptionOfRecipe = ReadInputDescriptionOfRecipe();
            if (nameOfRecipe && descriptionOfRecipe)
                ok = true;
            return ok;
        }

        //will control if user put valid name of recipe
        private bool ReadInputNameOfRecipe()
        {
            bool ok = true;
            string NameOfRecipe = textBoxNameOfRecipe.Text;
            NameOfRecipe = NameOfRecipe.Trim();

            if (NameOfRecipe == string.Empty)
            {
                MessageBox.Show("Add name of the recipe", "Error");
                ok = false;
            }
            return ok;
        }

        //will control if user put valid description of recipe
        private bool ReadInputDescriptionOfRecipe()
        {
            bool ok = true;
            string DescriptionOfRecipe = textBoxRecipe.Text;
            DescriptionOfRecipe = DescriptionOfRecipe.Trim();

            if (DescriptionOfRecipe == string.Empty)
            {
                MessageBox.Show("Add description of the recipe", "Error");
                ok = false;
            }
            return ok;
        }

        //After pressing "Add Recipe" button, the input will be validated, and values will be assign to the object of Recipe class
        

       

        //will unselect selected receipe
        private void buttonUnselect_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxRecipes.SelectedIndex;

            if (selectedIndex != -1)
            {
                listBoxRecipes.ClearSelected();
                textBoxNameOfRecipe.Text = string.Empty;
                textBoxRecipe.Clear();
            }
        }
    }
}
