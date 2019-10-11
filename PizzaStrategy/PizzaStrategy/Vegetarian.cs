using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStrategy
{
    class Vegetarian : Diet
    {
        public override bool CheckIfChangeable(List<string> ingredients)
        {
            return (ingredients.Contains("pepperoni") || ingredients.Contains("salami")
                || ingredients.Contains("salmon"));
        }

        public override void RemoveIngredients(List<string> ingredients)
        {
            ingredients.RemoveAll(t => t == "pepperoni" || t == "salami" || t == "salmon");
        }

        public override List<string> ReplaceIngredients(List<string> ingredients)
        {
            ingredients[ingredients.FindIndex(ind => ind.Equals("pepperoni") ||
                        ind.Equals("salami") || ind.Equals("salmon"))] = "mushroom";
            return ingredients;
        }
    }
}
