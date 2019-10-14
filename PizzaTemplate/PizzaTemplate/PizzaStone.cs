using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTemplate
{
    class PizzaStone
    {
        public void Prepare()
        {
            Console.WriteLine("Reaching the needed temperature");
        }

        public void Cook()
        {
            Console.WriteLine("The pizza is cooked on a pizza stone");
        }
    }
}
