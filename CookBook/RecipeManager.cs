//Michal Szukala
//2017.11.12

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

        //giving current number of items in the array
        public int CurrentNumOfItems()
        {
            int count = 0;
            for (int i = 0; i < recipeList.Length; i++)
                if (recipeList[i] != null)
                    count++;
            return count;
        }

        //checking in index is not out of bound
        public bool CheckIndex(int index)
        {
            if (index < recipeList.Length)
                return true;
            else
                return false; 

        }

        //getting recipe from array at the given index
        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
                return recipeList[index];
            else
                return null;
        }



        //removing Item from the recipeList
        public void DeleteItem(int selectedIndex, int maxNumOfElements)
        {
            if (selectedIndex >= 0)
            {
                recipeList[selectedIndex] = null;

                while (selectedIndex < maxNumOfElements)
                {
                    if (selectedIndex + 1 < maxNumOfElements && recipeList[selectedIndex + 1] != null)
                    {
                        recipeList[selectedIndex] = recipeList[selectedIndex + 1];
                        recipeList[selectedIndex + 1] = null;
                    }
                    else
                        break;

                    selectedIndex++;
                }
            }
        }

        //editing Item from the recipeList
        public void EditItem(int selectedIndex, int numOfIngrediens, FoodCategory foodCategory, string recipeName, string description)
        {

            if (selectedIndex >= 0)
            {
                Recipe currRecipe = new Recipe(numOfIngrediens);
                currRecipe.FoodCategory = foodCategory;
                currRecipe.RecipeName = recipeName;
                currRecipe.Description = description;
                currRecipe.IngredientsArray = recipeList[selectedIndex].IngredientsArray;

                Add(currRecipe, selectedIndex);
                currRecipe = null;
            }
            

        }
    }
}
