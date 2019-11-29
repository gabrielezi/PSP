using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelegate
{
    class VegetarianPizzaStoneBread : Bread, ITime, IVegetarian, IPizzaStone
    {
        private Time _time;
        private Vegetarian _vegetarian;
        private PizzaStone _pizzaStone;

        public VegetarianPizzaStoneBread(Time time, Vegetarian vegetarian, PizzaStone pizzaStone)
        {
            _time = time;
            _vegetarian = vegetarian;
            _pizzaStone = pizzaStone;
        }

        public bool CheckIfChangeable(List<string> ingredientList)
        {
            return _vegetarian.CheckIfChangeable(ingredientList);
        }

        public void Cook()
        {
            _pizzaStone.Cook();
        }

        public void Prepare()
        {
            _pizzaStone.Prepare();
        }

        public void RemoveIngredients(List<string> ingredientList)
        {
            _vegetarian.RemoveIngredients(ingredientList);
        }

        public List<string> ReplaceIngredients(List<string> ingredientList)
        {
            return _vegetarian.ReplaceIngredients(ingredientList);
        }

        public string TimePassed(DateTime time)
        {
            return _time.TimePassed(time);
        }
    }
}
