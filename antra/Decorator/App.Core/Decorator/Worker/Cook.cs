using App.Core.Interface;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Decorator.Worker
{
    public class Cook : WorkerDecorator, ISalary
    {
        private int _dish;

        public Cook(IWorker worker) : base(worker)
        {
            this._dish = 0;
            this.BadPlates = 0;
        }

        public int doDish(int dishes)
        {
            this._dish += dishes;
            this.BadPlates += dishes;

            return this._dish;
        }

        public int BadPlates { get; set; }

        public override double receiveSalary()
        {
            var temp = GetPerson(this);
            if (temp is SimpleWorker)
            {
                return base.receiveSalary() + (_dish * 2);
            }
            if (temp is SuperWorker)
            {
                return base.receiveSalary() + (_dish * 3);
            }
            return base.receiveSalary();
            
        }
    }
}
