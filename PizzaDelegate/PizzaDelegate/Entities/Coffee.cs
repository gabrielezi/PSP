using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelegate
{
    class Coffee
    {
        public string BeanName { get; set; }
        public List<string> Ingredients { get; set; }
        public char Size { get; set; }

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
