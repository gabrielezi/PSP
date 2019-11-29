using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraExtension
{
    public abstract class AbstractWorker : IWorker
    {
        private Dictionary<string, IWorkerExtension> _extensions = new Dictionary<string, IWorkerExtension>();
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

        public void AddExtension(string name, IWorkerExtension extension)
        {
            if (_extensions.ContainsValue(extension))
            {
                Console.WriteLine("This object is already extended by that type");
                return;
            }
            else
            {
                _extensions.Add(name, extension);
            }
            
        }

        public IWorkerExtension GetExtension(string name)
        {
            return _extensions[name];
        }

        public void RemoveExtension(string name)
        {
            _extensions.Remove(name);
        }
    }
}
