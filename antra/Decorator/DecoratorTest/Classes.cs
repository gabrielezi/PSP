using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Core.Models;

namespace DecoratorTest
{
    [TestClass]
    public class Classes
    {
        [TestMethod]
        public void TestRestaurantClass()
        {
            Restaurant worker = new Restaurant("GrillHouse", false);

            Assert.AreEqual("GrillHouse", worker.Title);
            Assert.IsFalse(worker.Working);
        }
        [TestMethod]
        public void TestRestaurantClassChangeIsWorking()
        {
            Restaurant worker = new Restaurant("GrillHouse", false);

            Assert.IsFalse(worker.Working);
            worker.Working = true;

            Assert.IsTrue(worker.Working);
        }
        [TestMethod]
        public void TestSimpleWorkerClass()
        {
            SimpleWorker worker = new SimpleWorker("Aurimas", new Restaurant("GrillHouse", true));

            Assert.AreEqual("Aurimas", worker.Name);
        }
        [TestMethod]
        public void TestSuperWorkerClass()
        {
            SuperWorker worker = new SuperWorker("Aurimas", new Restaurant("GrillHouse", true));

            Assert.AreEqual("Aurimas", worker.Name);
        }
    }
}
