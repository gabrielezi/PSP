using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraExtension.Extension
{
    class CookExtension : IWorkerExtension
    {
        public IWorker worker;
        private int _dish;

        public CookExtension(IWorker worker)
        {
            this._dish = 0;
            this.BadPlates = 0;
            this.worker = worker;
        }

        public int doDish(int dishes)
        {
            this._dish += dishes;
            this.BadPlates += dishes;

            return this._dish;
        }

        public int BadPlates { get; set; }
    }
}
