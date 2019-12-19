using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor
{
    public class SimpleWorker : AbstractWorker
    {
        public SimpleWorker(string name, Restaurant restaurant, double salary) : base(name, restaurant, salary)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitSimple(this);
        }
        public override void work()
        {
            Console.Out.WriteLine(String.Format("{0} dirba puse etato.", this.Name));
        }
    }
}
