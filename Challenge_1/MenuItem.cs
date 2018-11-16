using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class MenuItem
    {
        public string MealNumber { get; set; }
        public decimal MealPrice { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string Ingredients { get; set; }

        public MenuItem(string number, decimal mealPrice, string mealName, string mealDescription, string ingredients)
        {
            MealNumber = number;
            MealPrice = mealPrice;
            MealName = mealName;
            MealDescription = mealDescription;
            Ingredients = ingredients;
        }

        public MenuItem()
        {
        //internal bool Add(object list)
        //{
            //throw new NotImplementedException();
        //}

       // internal bool RemoveItem<T>(List<T> list)
        //{
           // throw new NotImplementedException();
        }


    }
}