using AntraExtension.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant grill = new Restaurant("GrillHouse", true);
            SimpleWorker worker = new SimpleWorker("Aurimas", grill);

            CookExtension ext = new CookExtension(worker);
            CleanerExtension ext2 = new CleanerExtension(worker);
            BartenderExtension ext3 = new BartenderExtension(worker);

            worker.AddExtension("CookExtension", ext);
            worker.AddExtension("CleanerExtension", ext2);
            worker.AddExtension("BartenderExtension", ext3);

            var workerRole = (CookExtension)worker.GetExtension("CookExtension");
            var workerRole2 = (CleanerExtension)worker.GetExtension("CleanerExtension");
            var workerRole3 = (BartenderExtension)worker.GetExtension("BartenderExtension");

            if (workerRole != null)
            {
                Console.WriteLine($"Bad plates {workerRole.BadPlates}");
            }
            if (workerRole2 != null)
            {
                Console.WriteLine($"Rooms cleaned: {workerRole2.cleanRoom(4)}");
            } 
            if (workerRole3 != null)
            {
                workerRole3.openRestaurant();
                Console.WriteLine($"Restaurant open: {grill.Working}");
                workerRole3.closeRestaurant();
                Console.WriteLine($"Restaurant open: {grill.Working}");
            }

            Console.ReadKey();
        }
    }
}
