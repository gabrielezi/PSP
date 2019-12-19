using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor
{
    public class SuperWorker : AbstractWorker
    {
        public SuperWorker(string name, Restaurant restaurant, double salary) : base(name, restaurant, salary)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitSuper(this);
        }
        public override void work()
        {
            Console.Out.WriteLine(String.Format("{0} dirba pilnu etatu.", this.Name));
        }
    }
}
