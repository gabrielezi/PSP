using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor.Visitor
{
    class CleanerVisitor : IVisitor
    {
        public IWorker worker;
        private int _rooms;
        public CleanerVisitor(IWorker worker)
        {
            this._rooms = 0;
            this.worker = worker;
            Console.WriteLine("{0} visited by {1}", worker.GetType().Name, this.GetType().Name);
        }
        
        public int cleanRoom(int rooms)
        {
            this._rooms += rooms;
            return this._rooms;
        }

        public void VisitSimple(SimpleWorker simpWorker)
        {
            Console.WriteLine($"Cleaner salary: { simpWorker.receiveSalary() + (_rooms * 1)}");
        }

        public void VisitSuper(SuperWorker simpWorker)
        {
            Console.WriteLine($"Cleaner salary: { simpWorker.receiveSalary() + (_rooms * 2)}");
        }
    }
}
