using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    class NoneDietCoffee : Coffee
    {
        public override bool CheckIfChangeable(List<string> ingredientList)
        {
            return false;
        }

        public override void RemoveIngredients(List<string> ingredientList)
        {
            Console.WriteLine("there's nothing to remove");
        }

        public override List<string> ReplaceIngredients(List<string> ingredientList)
        {
            Console.WriteLine("there's nothing to replace");
            return ingredientList;
        }
    }
}
