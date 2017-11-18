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
    }
}
