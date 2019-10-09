using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStrategy
{
    class NoneDiet : Diet
    {
        public override bool CheckIfChangeable(List<string> ingredients)
        {
            return false;
        }

        public override void RemoveIngredients(List<string> ingredients)
        {
            Console.WriteLine("there's nothing to remove");
        }

        public override void ReplaceIngredients(List<string> ingredients)
        {
            Console.WriteLine("there's nothing to replace");
        }
    }
}
