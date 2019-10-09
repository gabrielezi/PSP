using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStrategy
{
    class WoodFiredOven : CookingMethod
    {
        public override void Cook()
        {
            Console.WriteLine("The pizza is cooked in a wood fired oven");
        }

        public override void Prepare()
        {
            Console.WriteLine("Reaching the needed temperature");
        }
    }
}
