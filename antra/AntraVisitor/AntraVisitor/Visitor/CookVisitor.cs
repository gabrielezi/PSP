using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor.Visitor
{
    class CookVisitor : IVisitor
    {
        private int _dish;
        public IWorker worker;
        
        public CookVisitor(IWorker worker)
        {
            this._dish = 0;
            this.BadPlates = 0;
            this.worker = worker;
            Console.WriteLine("{0} visited by {1}", worker.GetType().Name, this.GetType().Name);
        }

        public int doDish(int dishes)
        {
            this._dish += dishes;
            this.BadPlates += dishes;

            return this._dish;
        }

        public void VisitSimple(SimpleWorker simpWorker)
        {
            Console.WriteLine($"Cook salary: {simpWorker.receiveSalary() + (_dish * 2)}");
        }

        public void VisitSuper(SuperWorker simpWorker)
        {
            Console.WriteLine($"Cook salary: {simpWorker.receiveSalary() + (_dish * 3)}");
        }

        public int BadPlates { get; set; }
    }
}
