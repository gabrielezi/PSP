﻿using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Interface
{
    public interface IWorker
    {
        void workPlace(Restaurant newRestaurant);
        void work();
    }
}
