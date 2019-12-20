using App.Core.Interface;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Decorator
{
    public abstract class WorkerDecorator : IWorker
    {
        public IWorker worker;

        public WorkerDecorator(IWorker worker)
        {
            this.worker = worker;
        }

        public void workPlace(Restaurant newRestaurant)
        {
            this.worker.workPlace(newRestaurant);
        }

        public void work()
        {
            worker.work();
        }

        public IWorker removeRole(string role)
        {
            if(this.worker.GetType().Equals(role))
            {
                return ((WorkerDecorator) this.worker).removeRole(role);
            } else
            {
                if(!(this.worker is AbstractWorker))
                {
                    this.worker = ((WorkerDecorator)this.worker).removeRole(role);
                }
                return this;
            }
        }

        public WorkerDecorator getRole(string role)
        {
            var tt = this.GetType().IsAssignableFrom(Type.GetType(role));
            if(this.GetType().IsAssignableFrom(Type.GetType(role)))
            {
               return this;
            }
            if(this.worker is WorkerDecorator)
            {
                return ((WorkerDecorator)this.worker).getRole(role);
            }
            return null;
        }
        public static IWorker GetPerson(IWorker comp)
        {
            if (comp is WorkerDecorator decor)
            {
                return GetPerson(decor.worker);
            }
            if (comp is SimpleWorker simple)
            {
                return simple;
            }
            else if (comp is SuperWorker stud)
            {
                return stud;
            }
            else if (comp is AbstractWorker pers)
            {
                return pers;
            }
            return null;
        }
        public virtual double receiveSalary()
        {
            return worker.receiveSalary();
        }
    }
}
