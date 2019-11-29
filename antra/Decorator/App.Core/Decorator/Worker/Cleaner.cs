using App.Core.Interface;
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
    }
}
