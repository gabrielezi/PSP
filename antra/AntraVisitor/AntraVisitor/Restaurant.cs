using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor
{
    public class Restaurant
    {
        public Restaurant(string title, bool working)
        {
            this.Title = title;
            this.Working = working;
        }

        public string Title { get; }
        public bool Working { get; set; }
    }
}
