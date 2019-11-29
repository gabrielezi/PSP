using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStrategy
{
    class Vegan : Diet
    {
        public override bool CheckIfChangeable(List<string> ingredients)
        {
            return (ingredients.Contains("milk") || ingredients.Contains("egg")
                || ingredients.Contains("cheese"));
        }

        public override void RemoveIngredients(List<string> ingredients)
        {
            ingredients.RemoveAll(t => t == "milk" || t == "egg" || t == "cheese");
        }

        public override List<string> ReplaceIngredients(List<string> ingredients)
        {
            try
            {
                ingredients[ingredients.FindIndex(ind => ind.Equals("milk"))] = "almondMilk";
                ingredients[ingredients.FindIndex(ind => ind.Equals("cheese"))] = "veganCheese";
                return ingredients;
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {

                Console.WriteLine("Error: {0}", outOfRange.Message);
                return ingredients;
            }

        }
    }
}
