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
        public void Visit(AbstractWorker worker)
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
    }
}
