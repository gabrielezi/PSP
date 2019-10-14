using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    class NoneDiet
    {
        public bool CheckIfChangeable(List<string> ingredientList)
        {
            return false;
        }
        public List<string> ReplaceIngredients(List<string> ingredientList)
        {
            Console.WriteLine("there's nothing to remove");
            return ingredientList;
        }
        public void RemoveIngredients(List<string> ingredientList)
        {
            Console.WriteLine("there's nothing to replace");
        }
    }
}
