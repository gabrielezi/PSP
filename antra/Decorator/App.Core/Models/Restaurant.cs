using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Models
{
    public class Restaurant
    {
        private readonly string _title;
        private bool _working;

        public Restaurant(string title, bool working)
        {
            this._title = title;
            this._working = working;
        }

        public string Title
        {
            get { return _title; }
        }

        public bool Working
        {
            get
            {
                return _working;
            }
            set
            {
                _working = value;
            }
        }
    }
}
