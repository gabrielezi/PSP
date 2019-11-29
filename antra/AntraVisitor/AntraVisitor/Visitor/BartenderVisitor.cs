using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor.Visitor
{
    class BartenderVisitor : IVisitor
    {
        public IWorker worker;
        private int _drinksSold;
        public void Visit(AbstractWorker worker)
        {
            this._drinksSold = 0;
            this.worker = worker;
            Console.WriteLine("{0} visited by {1}", worker.GetType().Name, this.GetType().Name);
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
