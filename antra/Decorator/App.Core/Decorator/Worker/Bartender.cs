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

    }
}
