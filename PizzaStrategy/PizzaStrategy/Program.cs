using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();
            List<string> pepperoniPizza = new List<string>()
            { "flour", "milk", "olive oil", "pepperoni", "cheese", "sauce"};
            pizza.SetIngredients(pepperoniPizza);

            Coffee coffee = new Coffee();
            List<string> coffeeIng = new List<string>()
                { "milk", "coffee beans", "sugar"};
            coffee.SetIngredients(coffeeIng);

            pizza.Make(new Vegetarian());

            Console.WriteLine("Your pizza:\n");
            pepperoniPizza.ForEach(Console.WriteLine);

            pizza.Bake(new WoodFiredOven());

            coffee.Make(new Vegan());
        
            coffee.ingredients.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
