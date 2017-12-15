//Michal Szukala
//2017.11.12


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
    //class is taking care of adding ingrediens to the recipe
    public partial class FormIngrediens : Form
    {
        private Recipe m_recipe;
        private string[] ingredientsArray;


        public FormIngrediens(Recipe recipe, int maxNumOfIngredients)
        {
            InitializeComponent();
            m_recipe = recipe;
            ingredientsArray = new string[maxNumOfIngredients];
            DefaultValues();
            InitializeGUI();
        }

        //set inside ingredientsArray empty strings
        public void DefaultValues()
        {
            for (int i = 0; i < ingredientsArray.Length; i++)
                ingredientsArray[i] = string.Empty;
        }

        //Will return first empty position in the ingrediensArray
        public int FindVacantPosition()
        {
            int emptySpace = -1;

            for (int i = 0; i < ingredientsArray.Length; i++)
                if (ingredientsArray[i] == string.Empty)
                {
                    emptySpace = i;
                    break;
                }
            return emptySpace;
        }

        //will save ingredient to the ingrediensArray if there is free space 
        public bool AddIngredient(string ingredient)
        {
            bool ok = true;
            int emptyIndex = FindVacantPosition();
            if (emptyIndex >= 0)
                ingredientsArray[emptyIndex] = ingredient;
            else
            {
                MessageBox.Show("Ingrediens's memory is full", "Error");
                ok = false;
            }

            return ok;
        }


        //will initialize begining valuses of GUI
        public void InitializeGUI()
        {
            if (m_recipe.IngredientsArray == null)
                m_recipe.IngredientsArray = new string[m_recipe.MaxNumOfIngrediens];

            labelNo.Text = m_recipe.GetCurrentNumOfIngrediens().ToString();
            textBoxPutIngredient.Text = string.Empty;
        }

        //will veryfy if user put any ingrediens
        private bool ReadInputIngrediens()
        {
            bool ok = true;
            if (textBoxPutIngredient.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You didn't add any ingrediens", "Error");
                ok = false;
            }
            return ok;
        }

        //After pressing "Add" button, it will add ingrediens to the list of ingrediens
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ReadInputIngrediens())
            {
                string ingredient = textBoxPutIngredient.Text.Trim();
                listBoxListOfIngrediens.Items.Add(ingredient);
                textBoxPutIngredient.Clear();
                AddIngredient(ingredient);
                m_recipe.IngredientsArray = ingredientsArray;
                labelNo.Text = m_recipe.GetCurrentNumOfIngrediens().ToString();
            }
        }

        //will print all Ingrediens
        public void showIngredients(Recipe recipe)
        {
            m_recipe = recipe;
            ingredientsArray = m_recipe.IngredientsArray;
            for (int i = 0; i < ingredientsArray.Length; i++)
                if (ingredientsArray[i] != string.Empty)
                    listBoxListOfIngrediens.Items.Add(ingredientsArray[i]);
            labelNo.Text = m_recipe.GetCurrentNumOfIngrediens().ToString();

        }


        //after clicking "Delete" button ingredient will be deleted 
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxListOfIngrediens.SelectedIndex;

            if (selectedIndex != -1)
            {
                ingredientsArray[selectedIndex] = string.Empty;

                while (selectedIndex < ingredientsArray.Length)
                {
                    if (selectedIndex + 1 < ingredientsArray.Length && ingredientsArray[selectedIndex + 1] != string.Empty)
                    {
                        ingredientsArray[selectedIndex] = ingredientsArray[selectedIndex + 1];
                        ingredientsArray[selectedIndex + 1] = string.Empty;
                    }
                    else
                        break;

                    selectedIndex++;
                }

                m_recipe.IngredientsArray = ingredientsArray;
                printIngredients();
                InitializeGUI();
            }
        }

        //will print ingrediens in the ListBox
        public void printIngredients()
        {
            listBoxListOfIngrediens.Items.Clear();
            for (int i = 0; i < ingredientsArray.Length; i++)
                if (ingredientsArray[i] != string.Empty)
                    listBoxListOfIngrediens.Items.Add(ingredientsArray[i]);
        }

        //after clicking "Edit" button ingredient will be edited 
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
            int selectedIndex = listBoxListOfIngrediens.SelectedIndex;

            if (selectedIndex != -1)
            {
                ingredientsArray[selectedIndex] = textBoxPutIngredient.Text;
                m_recipe.IngredientsArray = ingredientsArray;
                textBoxPutIngredient.Text = string.Empty;
                printIngredients();
            }

        }

        //after clicking on the ListBox with recipes, the details will be shown in the input fields
        private void listBoxListOfIngrediens_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxListOfIngrediens.SelectedIndex;

            if (selectedIndex != -1)
            {
                textBoxPutIngredient.Text = ingredientsArray[selectedIndex];
            }

        }

        ////will unselect selected ingredient
        private void buttonUnselect_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxListOfIngrediens.SelectedIndex;

            if (selectedIndex != -1)
            {
                listBoxListOfIngrediens.ClearSelected();
                textBoxPutIngredient.Text = string.Empty;
            }
        }
    }
}
