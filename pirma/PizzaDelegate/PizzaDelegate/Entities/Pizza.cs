using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelegate
{
    class Pizza
    {
        private DateTime _created;
        public DateTime GetCreationDate()
        {
            return _created;
        }
        public void SetCreationDate(DateTime time)
        {
            _created = time;
        }
        public char Size { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
