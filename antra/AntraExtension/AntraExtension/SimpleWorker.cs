using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraExtension
{
    public class SimpleWorker : AbstractWorker
    {
        public SimpleWorker(string name, Restaurant restaurant) : base(name, restaurant)
        {
        }

        public override void work()
        {
            Console.Out.WriteLine(String.Format("{0} dirba puse etato.", this.Name));
        }
    }
}
