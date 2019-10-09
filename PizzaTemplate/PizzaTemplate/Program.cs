using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Vegetarian_WoodFiredOvenPizza vegPizza = new Vegetarian_WoodFiredOvenPizza();
            List<string> pepperoniPizza = new List<string>()
            { "flour", "milk", "olive oil", "pepperoni", "cheese", "sauce"};
            vegPizza.SetIngredients(pepperoniPizza);

            vegPizza.MakePizza(vegPizza.ingredients);
            vegPizza.ingredients.ForEach(Console.WriteLine);
            vegPizza.Bake();

            Console.WriteLine("\n");
            VeganCoffee coffee = new VeganCoffee();
            List<string> coffeeIng = new List<string>()
                { "milk", "coffee beans", "sugar"};
            coffee.SetIngredients(coffeeIng);
            coffee.MakeCoffee(coffee.ingredients);
            coffee.ingredients.ForEach(Console.WriteLine);
        }
    }
}
