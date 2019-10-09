using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStrategy
{
    public abstract class CookingMethod
    {
        public abstract void Prepare();
        public abstract void Cook();
    }
}
