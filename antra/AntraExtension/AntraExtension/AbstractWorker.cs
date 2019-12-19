using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraExtension
{
    public abstract class AbstractWorker : IWorker
    {
        private readonly IList<IWorkerExtension> _extensions;
        public string Name;
        public Restaurant Restaurant;
        private double salary;

        public AbstractWorker(string name, Restaurant restaurant, double salary)
        {
            this.Name = name;
            this.Restaurant = restaurant;
            this.salary = salary;
            _extensions = new List<IWorkerExtension>();
        }

        public void workPlace(Restaurant newRestaurant)
        {
            this.Restaurant = newRestaurant;
        }

        public abstract void work();

        public void AddExtension<T>(T extension) where T : IWorkerExtension
        {
            if (!_extensions.Any(existingExtension => existingExtension is T))
            {
                _extensions.Add(extension);
            }
            else
            {
                Console.WriteLine("ExtensionAlreadyAdded");
            }
        }

        public void RemoveExtension<T>() where T : IWorkerExtension
        {
            IWorkerExtension toRemove = _extensions.FirstOrDefault(extension => extension is T);
            if (toRemove == null)
            {
                Console.WriteLine("Extension was not added");
            }
            _extensions.Remove(toRemove);
        }

        public T GetExtension<T>() where T : IWorkerExtension
        {
            T result = (T)_extensions.FirstOrDefault(extension => extension is T);
            if (result == null)
            {
                Console.WriteLine("Extension was not added");
            }
            return result;
        }

        public double receiveSalary()
        {
            return salary;
        }
    }
}
