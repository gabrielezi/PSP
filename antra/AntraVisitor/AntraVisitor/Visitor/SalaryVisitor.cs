using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor.Visitor
{
    public class SalaryVisitor : IVisitor
    {
        public void Visit(IWorker worker)
        {
            throw new NotImplementedException();
        }

        public void VisitSimple(SimpleWorker simpWorker)
        {
            throw new NotImplementedException();
        }

        public void VisitSuper(SuperWorker simpWorker)
        {
            throw new NotImplementedException();
        }
    }
}
