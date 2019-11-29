using App.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Decorator.Worker
{
    public class Cook : WorkerDecorator
    {
        private int _dish;
        private int _plates;

        public Cook(IWorker worker) : base(worker)
        {
            this._dish = 0;
            this._plates = 0;
        }

        public int doDish(int dishes)
        {
            this._dish += dishes;
            this._plates += dishes;

            return this._dish;
        }

        public int BadPlates 
        { 
            get
            {
                return _plates;
            }
            set
            {
                _plates = value;
            }
        }
    }
}
