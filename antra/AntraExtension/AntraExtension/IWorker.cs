using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraExtension
{
    public interface IWorker
    {
        void workPlace(Restaurant newRestaurant);
        void work();
    }
}
