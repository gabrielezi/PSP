using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraExtension.Extension
{
    class BartenderExtension : IWorkerExtension
    {
        public IWorker worker;
        private int _drinksSold;
        public BartenderExtension(IWorker worker)
        {
            this._drinksSold = 0;
            this.worker = worker;
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
