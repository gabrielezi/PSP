using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor
{
    public interface IVisitor
    {
        void VisitSimple(SimpleWorker simpWorker);
        void VisitSuper(SuperWorker simpWorker);
    }
}