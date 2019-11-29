using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor
{
    abstract class AbstractWorker : IWorker
    {
        public string Name;
        public Restaurant Restaurant;

        public AbstractWorker(string name, Restaurant restaurant)
        {
            this.Name = name;
            this.Restaurant = restaurant;
        }

        public void workPlace(Restaurant newRestaurant)
        {
            this.Restaurant = newRestaurant;
        }
        public abstract void work();
        public abstract void Accept(IVisitor visitor);
    }
}
