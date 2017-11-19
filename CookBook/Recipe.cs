using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    //class is creating Recipe object which is responsible for name of recipe, ingrediens, description..
    public class Recipe
    {
        private string[] ingredientsArray;
        private string recipeName;
        private FoodCategory foodCategory;
        private string description;


        //Constractor for the class
        public Recipe(int maxNumOfIngrediens)
        {
            ingredientsArray = new string[maxNumOfIngrediens];
            DefaultValues();
        }


        //Assigning properties for the Recipe class objects
        public string[] IngredientsArray

        {
            get { return ingredientsArray; }
            set { ingredientsArray = value; }
        }

        public string RecipeName
        {
            get { return recipeName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    recipeName = value;
            }
        }

         public FoodCategory FoodCategory
        {
            get { return foodCategory; }
            set { foodCategory = value; }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }

        public int MaxNumOfIngrediens
        {
            get { return ingredientsArray.Length; }
        }


        //Set instance variables to default values
        public void DefaultValues()
        {
            for (int i = 0; i < ingredientsArray.Length; i++)
                ingredientsArray[i] = string.Empty;

            recipeName = string.Empty;
            foodCategory = FoodCategory.Meat;
            description = string.Empty;
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
                ok = false;

            return ok;
        }

        //will checki if given index is inside of array 
        public bool CheckIndex(int index)
        {
            if (index >= 0 && index < ingredientsArray.Length)
                return true;
            else
                return false;
        }


        //will get a number of ingrediens in the array 
        public int GetCurrentNumOfIngrediens()
        {
            int count = 0;
            for (int i = 0; i < ingredientsArray.Length; i++)
                if (!string.IsNullOrEmpty(ingredientsArray[i]))
                    count++;
            return count;
        }

        //new ToString method showing name, number of ingrediens and food category 
        public override string ToString()
        {
            int chars = Math.Min(description.Length, 15);
            string descriptionText = description.Substring(0, chars);

            if (string.IsNullOrEmpty(descriptionText))
                descriptionText = "No description";

            string textOut = string.Format("{0, -45} {1,-50} {2, -30} {3, -25}", recipeName, GetCurrentNumOfIngrediens(), foodCategory.ToString(), descriptionText);
            return textOut;
        }
    }
}
