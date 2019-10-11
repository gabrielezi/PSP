using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    class VegetarianCoffee : Coffee
    {
        public override bool CheckIfChangeable(List<string> ingredientList)
        {
            return (ingredientList.Contains("pepperoni") || ingredientList.Contains("salami")
                || ingredientList.Contains("salmon") || ingredientList.Contains("gelatin"));
        }
        public override List<string> ReplaceIngredients(List<string> ingredientList)
        {
            ingredientList[ingredientList.FindIndex(ind => ind.Equals("pepperoni") ||
                        ind.Equals("salami") || ind.Equals("salmon"))] = "mushroom";
            return ingredientList;
        }
        public override void RemoveIngredients(List<string> ingredientList)
        {
            ingredientList.RemoveAll(t => t == "pepperoni" || t == "gelatin" || t == "salmon");
        }
    }
}
