using App.Core.Interface;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Decorator.Worker
{
    public class Bartender : WorkerDecorator
    {
        private int _drinksSold;

        public Bartender(IWorker worker) : base(worker)
        {
            this._drinksSold = 0;
        }

        public int Sell(int drinks)
        {
            this._drinksSold += drinks;
            return this._drinksSold;
        }

        public void closeRestaurant()
        {
            AbstractWorker worker = (AbstractWorker)this.worker;
            worker.Restaurant.Working = false;
        }

        public void openRestaurant()
        {
            AbstractWorker worker = (AbstractWorker)this.worker;
            worker.Restaurant.Working = true;
        }
        public override double receiveSalary()
        {
            var temp = GetPerson(this);
            if (temp is SimpleWorker)
            {
                return base.receiveSalary() + (_drinksSold * 2);
            }
            else if (temp is SuperWorker)
            {
                return base.receiveSalary() + (_drinksSold * 4);
            }
            else return base.receiveSalary();
        }
    }
}
