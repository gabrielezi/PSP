using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelegate
{
    interface IVegetarian
    {
        bool CheckIfChangeable(List<string> ingredientList);
        List<string> ReplaceIngredients(List<string> ingredientList);
        void RemoveIngredients(List<string> ingredientList);
    }
}
