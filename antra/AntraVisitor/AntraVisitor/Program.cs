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
            IWorker worker = new SimpleWorker("Aurimas", grill);  //iworker
            CookVisitor vsCook = new CookVisitor();
            worker.Accept(vsCook);
            vsCook.doDish(3);
            Console.WriteLine($"Bad plates: {vsCook.BadPlates}");

            CleanerVisitor vsCleaner = new CleanerVisitor();
            worker.Accept(vsCleaner);
            Console.WriteLine($"Rooms cleaned: {vsCleaner.cleanRoom(5)}");

            BartenderVisitor vsBartender = new BartenderVisitor();
            worker.Accept(vsBartender);
            Console.WriteLine($"Drinks sold: {vsBartender.Sell(4)}");

        }
    }
}
