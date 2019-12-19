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
            AbstractWorker worker = new SimpleWorker("Aurimas", grill, 600);

            worker.AddExtension(new CookExtension(worker));
            worker.AddExtension(new CleanerExtension(worker));
            worker.AddExtension(new BartenderExtension(worker));

            var workerRole = worker.GetExtension<CookExtension>();

            if (workerRole != null)
            {
                workerRole.doDish(3);
                Console.WriteLine($"Cook salary {workerRole.receiveSalary()}");
            }

            var workerRole2 = worker.GetExtension<CleanerExtension>();

            if (workerRole2 != null)
            {
                workerRole2.cleanRoom(5);
                Console.WriteLine($"Cleaner salary {workerRole2.receiveSalary()}");
            }

            var workerRole3 = worker.GetExtension<BartenderExtension>();

            if (workerRole3 != null)
            {
                workerRole3.Sell(10);
                Console.WriteLine($"Bartender salary {workerRole3.receiveSalary()}");
            }

            Console.ReadKey();
        }
    }
}
