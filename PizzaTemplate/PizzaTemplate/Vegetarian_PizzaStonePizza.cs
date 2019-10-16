using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    class Vegetarian_PizzaStonePizza : Pizza
    {
        protected override bool CheckIfChangeable(List<string> ingredientList)
        {
            return (ingredientList.Contains("pepperoni") || ingredientList.Contains("salami")
                || ingredientList.Contains("salmon"));
        }
        protected override List<string> ReplaceIngredients(List<string> ingredientList)
        {
            ingredientList[ingredientList.FindIndex(ind => ind.Equals("pepperoni") ||
                        ind.Equals("salami") || ind.Equals("salmon"))] = "mushroom";
            return ingredientList;
        }
        protected override void RemoveIngredients(List<string> ingredientList)
        {
            ingredientList.RemoveAll(t => t == "pepperoni" || t == "salami" || t == "salmon");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Reaching the needed temperature");
        }

        protected override void Cook()
        {
            Console.WriteLine("The pizza is cooked on a pizza stone");
        }
    }
}
