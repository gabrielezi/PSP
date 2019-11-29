using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor
{
    class SuperWorker : AbstractWorker
    {
        public SuperWorker(string name, Restaurant restaurant) : base(name, restaurant)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public override void work()
        {
            Console.Out.WriteLine(String.Format("{0} dirba pilnu etatu.", this.Name));
        }
    }
}
