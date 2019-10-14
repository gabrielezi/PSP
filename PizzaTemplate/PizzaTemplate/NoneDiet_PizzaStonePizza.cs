using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    class NoneDiet_PizzaStonePizza : Pizza
    {
        private NoneDiet _noneDiet;
        private PizzaStone _pizzaStone;
        public NoneDiet_PizzaStonePizza(NoneDiet diet, PizzaStone stone)
        {
            _noneDiet = diet;
            _pizzaStone = stone;
        }
        public override bool CheckIfChangeable(List<string> ingredientList)
        {
            return _noneDiet.CheckIfChangeable(ingredientList);
        }

        public override void Cook()
        {
            _pizzaStone.Cook();
        }

        public override void Prepare()
        {
            _pizzaStone.Prepare();
        }

        public override void RemoveIngredients(List<string> ingredientList)
        {
            _noneDiet.RemoveIngredients(ingredientList);
        }

        public override List<string> ReplaceIngredients(List<string> ingredientList)
        {
            return _noneDiet.ReplaceIngredients(ingredientList);
        }
    }
}
