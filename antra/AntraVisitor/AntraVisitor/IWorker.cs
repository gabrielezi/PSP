using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor
{
    public interface IWorker
    {
        void workPlace(Restaurant newRestaurant);
        void work();
        public abstract void Accept(IVisitor visitor);
        double receiveSalary();
    }
}
