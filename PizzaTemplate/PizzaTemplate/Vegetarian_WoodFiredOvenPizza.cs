using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    class Vegetarian_WoodFiredOvenPizza : Pizza
    {
        public override bool CheckIfChangeable(List<string> ingredientList)
        {
            return (ingredientList.Contains("pepperoni") || ingredientList.Contains("salami")
                || ingredientList.Contains("salmon"));
        }
        public override void ReplaceIngredients(List<string> ingredientList)
        {
            ingredientList[ingredientList.FindIndex(ind => ind.Equals("pepperoni") ||
                        ind.Equals("salami") || ind.Equals("salmon"))] = "mushroom";
        }
        public override void RemoveIngredients(List<string> ingredientList)
        {
            ingredientList.RemoveAll(t => t == "pepperoni" || t == "salami" || t == "salmon");
        }

        public override void Prepare()
        {
            Console.WriteLine("Reaching the needed temperature");
        }

        public override void Cook()
        {
            Console.WriteLine("The pizza is cooked in a wood fired oven");
        }
    }
}
