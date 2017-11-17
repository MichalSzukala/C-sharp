using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook
{
    //class will store all the recipes send by Recipe class
    class RecipeManager
    {
        private Recipe[] recipeList;


        public RecipeManager(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements];
        }

        //Assigning properties for the RecipeManager class objects
        public Recipe[] RecipeList

        {
            get { return recipeList; }
            set { recipeList = value; }
        }

        //Will return first empty position in the recipeList array
        private int FindVacantPosition()
        {
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] == null)
                    return i;
            }
            return -1;
        }

        //will save recipe object into recipeList array if there is free space, and return true/false
        public bool Add(Recipe newRecipe)
        {
            bool ok = true;
            int emptyIndex = FindVacantPosition();

            if (emptyIndex >= 0 && newRecipe != null)
            {

                recipeList[emptyIndex] = newRecipe;
            }
            else
            {
                MessageBox.Show("Recipe's memory is full", "Error");
                ok = false;
            }

            return ok;

        }

        //overloaded Add method 
        public bool Add(Recipe newRecipe, int index)
        {
            bool ok = true;

            if (newRecipe != null)
            {

                recipeList[index] = newRecipe;
            }
            else
                ok = false;
            return ok;

        }
    }
}
