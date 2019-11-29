using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    abstract class Pizza
    {
        private List<string> ingredients;
        private string pizzaType;

        public void SetPizzaType(string type)
        {
            pizzaType = type;
        }
        public List<string> GetIngredients()
        {
            return ingredients;
        }
        public void SetIngredients(List<string> ingredientList)
        {
            ingredients = ingredientList;
        }
        protected abstract bool CheckIfChangeable(List<string> ingredientList);
        protected abstract List<string> ReplaceIngredients(List<string> ingredientList);
        protected abstract void RemoveIngredients(List<string> ingredientList);
        public void MakePizza(List<string> ingredientList)
        {
            if (CheckIfChangeable(ingredientList))
            {
                ingredientList = ReplaceIngredients(ingredientList);
                RemoveIngredients(ingredientList); 
            }
        }
        protected abstract void Prepare();
        protected abstract void Cook();

        public void Bake()
        {
            Prepare();
            Cook();
        }
        
    }
}
