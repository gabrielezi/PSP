using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    class VeganCoffee : Coffee
    {
        public override bool CheckIfChangeable(List<string> ingredientList)
        {
            return (ingredientList.Contains("milk") || ingredientList.Contains("cream"));
        }

        public override void RemoveIngredients(List<string> ingredientList)
        {
            ingredientList.RemoveAll(t => t == "milk" || t == "cream");
        }

        public override List<string> ReplaceIngredients(List<string> ingredientList)
        {
            ingredientList[ingredientList.FindIndex(ind => ind.Equals("milk"))] = "almondMilk";
            return ingredientList;
        }
    }
}
