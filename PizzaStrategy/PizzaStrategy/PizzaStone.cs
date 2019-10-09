using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStrategy
{
    class PizzaStone : CookingMethod
    {
        public override void Cook()
        {
            Console.WriteLine("The pizza is cooked on a pizza stone");
        }

        public override void Prepare()
        {
            Console.WriteLine("Reaching the needed temperature");
        }
    }
}
