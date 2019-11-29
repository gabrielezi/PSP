using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor
{
    interface IVisitor
    {
        void Visit(AbstractWorker worker);
    }
}