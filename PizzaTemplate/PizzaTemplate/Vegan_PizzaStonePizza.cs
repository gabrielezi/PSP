using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    class Vegan_PizzaStonePizza : Pizza
    {
        public override bool CheckIfChangeable(List<string> ingredientList)
        {
            return (ingredientList.Contains("milk") || ingredientList.Contains("egg")
                || ingredientList.Contains("cheese"));
        }
        public override List<string> ReplaceIngredients(List<string> ingredientList)
        {
            ingredientList[ingredientList.FindIndex(ind => ind.Equals("milk"))] = "almondMilk";
            ingredientList[ingredientList.FindIndex(ind => ind.Equals("cheese"))] = "veganCheese";
            return ingredientList;
        }
        public override void RemoveIngredients(List<string> ingredientList)
        {
            ingredientList.RemoveAll(t => t == "milk" || t == "egg" || t == "cheese");
        }

        public override void Prepare()
        {
            Console.WriteLine("Reaching the needed temperature");
        }

        public override void Cook()
        {
            Console.WriteLine("The pizza is cooked on a pizza stone");
        }
    }
}
