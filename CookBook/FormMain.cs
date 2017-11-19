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
        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            
            currRecipe.FoodCategory = (FoodCategory)comboBoxCategory.SelectedIndex;
            currRecipe.RecipeName = textBoxNameOfRecipe.Text.Trim();
            currRecipe.Description = textBoxRecipe.Text.Trim();

            recipeMngr.Add(currRecipe);
            printAllRecipes();
            currRecipe = new Recipe(numOfIngrediens);
            currRecipe.DefaultValues();
            InitializeGUI();
        }

        //will print every recipes stored in Recipes array
        private void printAllRecipes()
        {
            Recipe[] recipeList = recipeMngr.RecipeList;
            listBoxRecipes.Items.Clear();
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] != null)
                    listBoxRecipes.Items.Add(recipeList[i].ToString());
            }
        }

        //After pressing "Add ingrediens" button, there will be open new window
        private void buttonAddIngrediens_Click(object sender, EventArgs e)
        {
            FormIngrediens dlg = new FormIngrediens(currRecipe, numOfIngrediens);

            int selectedIndex = listBoxRecipes.SelectedIndex;
            
            if (selectedIndex >= 0)
            {   
                Recipe editingRecipe = recipeMngr.RecipeList[selectedIndex];
                dlg.showIngredients(editingRecipe);
            }
            DialogResult dlgResult = dlg.ShowDialog();
            printAllRecipes();
        }


        //after clicking on the ListBox with recipes, the details will be shown in the input fields
        private void listBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxRecipes.SelectedIndex;

            if (selectedIndex != -1)
            {
                textBoxNameOfRecipe.Text = recipeMngr.RecipeList[selectedIndex].RecipeName;
                textBoxRecipe.Text = recipeMngr.RecipeList[selectedIndex].Description;
                comboBoxCategory.SelectedIndex = (int)recipeMngr.RecipeList[selectedIndex].FoodCategory;
            }
        }

        //after selecting recipe details, they will be displayed in the input fields.  Then it's possible to change them,
        //and after clicking "Edit" button recipe will be modyfy
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            int selectedIndex = listBoxRecipes.SelectedIndex;

            currRecipe.FoodCategory = (FoodCategory)comboBoxCategory.SelectedIndex;
            currRecipe.RecipeName = textBoxNameOfRecipe.Text.Trim();
            currRecipe.Description = textBoxRecipe.Text.Trim();
            currRecipe.IngredientsArray = recipeMngr.RecipeList[selectedIndex].IngredientsArray;

            recipeMngr.Add(currRecipe, selectedIndex);
            printAllRecipes();
            currRecipe = new Recipe(numOfIngrediens);
            currRecipe.DefaultValues();
            InitializeGUI();
        }

        //after clicking "Delete" button recipe will be deleted and all the recipes on the right in the array will be moved one place left
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            int selectedIndex = listBoxRecipes.SelectedIndex;

            if (selectedIndex != -1)
            {
                recipeMngr.RecipeList[selectedIndex] = null;

                while (selectedIndex < maxNumOfElements)
                {
                    if (selectedIndex + 1 < maxNumOfElements && recipeMngr.RecipeList[selectedIndex + 1] != null)
                    {
                        recipeMngr.RecipeList[selectedIndex] = recipeMngr.RecipeList[selectedIndex + 1];
                        recipeMngr.RecipeList[selectedIndex + 1] = null;
                    }
                    else
                        break;

                    selectedIndex++;
                }

                printAllRecipes();
                InitializeGUI();
            }
        }

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
