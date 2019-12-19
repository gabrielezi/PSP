using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor
{
    public abstract class AbstractWorker : IWorker
    {
        public string Name;
        public Restaurant Restaurant;
        private double salary;

        public AbstractWorker(string name, Restaurant restaurant, double salary)
        {
            this.Name = name;
            this.Restaurant = restaurant;
            this.salary = salary;
        }

        public void workPlace(Restaurant newRestaurant)
        {
            this.Restaurant = newRestaurant;
        }
        public abstract void work();
        public abstract void Accept(IVisitor visitor);
        public double receiveSalary()
        {
            return salary;
        }
    }
}
