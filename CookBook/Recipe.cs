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
        //private FoodCategory foodCategory;
        private string description;


        //Constractor for the class
        public Recipe(int maxNumOfIngrediens)
        {
            ingredientsArray = new string[maxNumOfIngrediens];
            //DefaultValues();
        }


       
    }
}
