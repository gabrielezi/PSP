using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelegate
{
    class Vegetarian : IVegetarian
    {
        public bool CheckIfChangeable(List<string> ingredientList)
        {
            return (ingredientList.Contains("pepperoni") || ingredientList.Contains("salami")
                || ingredientList.Contains("salmon"));
        }
        public List<string> ReplaceIngredients(List<string> ingredientList)
        {
            ingredientList[ingredientList.FindIndex(ind => ind.Equals("pepperoni") ||
                        ind.Equals("salami") || ind.Equals("salmon"))] = "mushroom";
            return ingredientList;
        }
        public void RemoveIngredients(List<string> ingredientList)
        {
            ingredientList.RemoveAll(t => t == "pepperoni" || t == "salami" || t == "salmon");
        }
    }
}
