using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    class NoneDiet_WoodFiredOvenPizza : Pizza
    {
        protected override bool CheckIfChangeable(List<string> ingredientList)
        {
            return false;
        }
        protected override List<string> ReplaceIngredients(List<string> ingredientList)
        {
            Console.WriteLine("there's nothing to remove");
            return ingredientList;
        }
        protected override void RemoveIngredients(List<string> ingredientList)
        {
            Console.WriteLine("there's nothing to replace");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Reaching the needed temperature");
        }

        protected override void Cook()
        {
            Console.WriteLine("The pizza is cooked in a wood fired oven");
        }
    }
}
