using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    abstract class Coffee
    {
        public List<string> ingredients;

        public void SetIngredients(List<string> ingredientList)
        {
            ingredients = ingredientList;
        }
        public abstract bool CheckIfChangeable(List<string> ingredientList);
        public abstract void ReplaceIngredients(List<string> ingredientList);
        public abstract void RemoveIngredients(List<string> ingredientList);
        public void MakeCoffee(List<string> ingredientList)
        {
            if (CheckIfChangeable(ingredientList))
            {
                ReplaceIngredients(ingredientList);
                RemoveIngredients(ingredientList);
            }
        }
    }
}
