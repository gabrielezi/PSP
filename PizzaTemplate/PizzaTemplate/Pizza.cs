using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    abstract class Pizza
    {
        public List<string> ingredients;
        string pizzaType;

        public void SetPizzaType(string type)
        {
            pizzaType = type;
        }
        public void SetIngredients(List<string> ingredientList)
        {
            ingredients = ingredientList;
        }
        public abstract bool CheckIfChangeable(List<string> ingredientList);
        public abstract void ReplaceIngredients(List<string> ingredientList);
        public abstract void RemoveIngredients(List<string> ingredientList);
        public void MakePizza(List<string> ingredientList)
        {
            if (CheckIfChangeable(ingredientList))
            {
                ReplaceIngredients(ingredientList);
                RemoveIngredients(ingredientList); 
            }
        }
        public abstract void Prepare();
        public abstract void Cook();

        public void Bake()
        {
            Prepare();
            Cook();
        }
        
    }
}
