using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraExtension.Extension
{
    class CleanerExtension : ICleaner
    {
        public IWorker worker;
        private int _rooms;
        public CleanerExtension(AbstractWorker worker)
        {
            this._rooms = 0;
            this.worker = worker;
        }
        public int cleanRoom(int rooms)
        {
            this._rooms += rooms;
            return this._rooms;
        }
        public double receiveSalary()
        {
            if (worker is SimpleWorker)
            {
                return worker.receiveSalary() + (_rooms * 1);
            }
            if (worker is SuperWorker)
            {
                return worker.receiveSalary() + (_rooms * 2);
            }
            return worker.receiveSalary();
        }
    }
}
