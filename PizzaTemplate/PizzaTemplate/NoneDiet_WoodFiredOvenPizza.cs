using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    class NoneDiet_WoodFiredOvenPizza : Pizza
    {
        public override bool CheckIfChangeable(List<string> ingredientList)
        {
            return false;
        }
        public override void ReplaceIngredients(List<string> ingredientList)
        {
            Console.WriteLine("there's nothing to remove");
        }
        public override void RemoveIngredients(List<string> ingredientList)
        {
            Console.WriteLine("there's nothing to replace");
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
