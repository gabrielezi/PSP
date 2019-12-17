using App.Core.Interface;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Decorator.Worker
{
    public class Cleaner : WorkerDecorator
    {
        private int _rooms;

        public Cleaner(IWorker worker) : base(worker)
        {
            this._rooms = 0;
        }

        public int cleanRoom(int rooms)
        {
            this._rooms += rooms;

            return this._rooms;
        }
     
        public override double receiveSalary()
        {
            var temp = GetPerson(this);
            if (temp is SimpleWorker)
            {
                return base.receiveSalary() + (_rooms * 1);
            }
            else if (temp is SuperWorker)
            {
                return base.receiveSalary() + (_rooms * 2);
            }
            else return base.receiveSalary();
        }
    }
}
