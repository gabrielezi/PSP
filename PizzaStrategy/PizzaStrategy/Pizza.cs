using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStrategy
{
    public class Pizza 
    {
        CookingMethod cookingMethod;
        string pizzaType;

        public List<string> ingredients;

        public Diet _diet;

        public void SetPizzaType(string type)
        {
            pizzaType = type;
        }

        public void SetIngredients(List<string> ingredientList)
        {
            ingredients = ingredientList;
        }

        public void Make(Diet diet)
        {
            _diet = diet;
            if (_diet.CheckIfChangeable(ingredients))
            {
                ingredients = _diet.ReplaceIngredients(ingredients);
                _diet.RemoveIngredients(ingredients);
            }
        }

        public void Bake(CookingMethod cookingM)
        {
            cookingMethod = cookingM;
            cookingMethod.Prepare();
            cookingMethod.Cook();
        }
    }
}
