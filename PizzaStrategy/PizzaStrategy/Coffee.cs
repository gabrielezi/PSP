using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStrategy
{
    class Coffee
    {
        string beanType;

        public List<string> ingredients;

        public Diet _diet;

        public string GetBeanType()
        {
            return beanType;
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
    }
}
