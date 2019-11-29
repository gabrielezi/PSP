using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelegate
{
    class Bread
    {
        public List<string> Ingredients { get; set; }
        public string Type { get; set; }

        private DateTime _created;
        public string GetCreationDate()
        {
            return _created.ToString("yyyy/MM/dd hh:mm:ss");
        }
        public void SetCreationDate(DateTime time)
        {
            _created = time;
        }
    }
}
