using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStrategy
{
    public abstract class Diet
    {
        public abstract bool CheckIfChangeable(List<string> ingredients);
        public abstract List<string> ReplaceIngredients(List<string> ingredients);
        public abstract void RemoveIngredients(List<string> ingredients);
    
    }
}
