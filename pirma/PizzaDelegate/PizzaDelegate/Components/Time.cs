using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelegate
{
    class Time : ITime
    {
        public string TimePassed(DateTime time)
        {
            var timeCreated = DateTime.Now - time;
            return $"{timeCreated.Hours} hours {timeCreated.Minutes} minutes {timeCreated.Seconds} seconds";
        }
    }
}
