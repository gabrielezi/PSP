using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Core.Decorator;
using App.Core.Decorator.Worker;
using App.Core.Interface;
using App.Core.Models;

namespace DecoratorTest
{
    [TestClass]
    public class Decorator
    {
        [TestMethod]
        public void TestDecodator()
        {
            Restaurant restaurant = new Restaurant("Cili", true);
            IWorker worker = new SimpleWorker("Aurimas", restaurant);
            Bartender bartender = new Bartender(worker);

            Assert.AreEqual(0, bartender.Sell(0));
            Assert.AreEqual(10, bartender.Sell(10));

            bartender.closeRestaurant();
            Assert.IsFalse(restaurant.Working);
        }

        [TestMethod]
        public void TestRole()
        {
            SimpleWorker simpleWorker = new SimpleWorker("Simas", new Restaurant("Test", true));
            SuperWorker superWorker = new SuperWorker("Petras", new Restaurant("Bao", false));

            IWorker worker = new Bartender(new Cleaner(superWorker));
            Assert.AreEqual(10, ((Cleaner)((WorkerDecorator)worker).getRole("App.Core.Decorator.Worker.Cleaner")).cleanRoom(10));
            Assert.AreEqual(10, ((Bartender)((WorkerDecorator)worker).getRole("App.Core.Decorator.Worker.Bartender")).Sell(10));

            worker = (WorkerDecorator)((WorkerDecorator)worker).removeRole("App.Core.Decorator.Worker.Bartender");
            worker.work();

        }
    }
}
