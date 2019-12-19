using AntraVisitor.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant grill = new Restaurant("GrillHouse", true);
            IWorker worker = new SimpleWorker("Aurimas", grill, 500);

            CookVisitor vsCook = new CookVisitor(worker);
            vsCook.doDish(3);
            worker.Accept(vsCook);

            CleanerVisitor vsCleaner = new CleanerVisitor(worker);
            vsCleaner.cleanRoom(5);
            worker.Accept(vsCleaner);

            BartenderVisitor vsBartender = new BartenderVisitor(worker);
            vsBartender.Sell(4);
            worker.Accept(vsBartender);

        }
    }
}
