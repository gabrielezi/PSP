using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Models
{
    public class SimpleWorker : AbstractWorker
    {
        public SimpleWorker(string name, Restaurant restaurant, double salary) : base(name, restaurant, salary)
        {
        }

        public override void work()
        {
            Console.Out.WriteLine(String.Format("{0} dirba puse etato.", this.Name));
        }
    }
}
