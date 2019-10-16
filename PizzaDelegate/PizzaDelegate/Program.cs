using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegPizza = new VegetarianPizzaStonePizza(new Time(), new Vegetarian(), new PizzaStone());

            List<string> pepperoniIngred = new List<string>()
            { "flour", "milk", "olive oil", "pepperoni", "cheese", "sauce"};
            vegPizza.Ingredients = pepperoniIngred;
            vegPizza.SetCreationDate(new DateTime(2019, 10, 14));

            vegPizza.MakePizza(vegPizza.Ingredients);
            vegPizza.Ingredients.ForEach(Console.WriteLine);
            vegPizza.Bake();

            Console.WriteLine(vegPizza.TimePassed(vegPizza.GetCreationDate()));

        }
    }
}
