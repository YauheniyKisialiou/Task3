using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurant.human;
using Restaurant.rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MyTestClass
    {

        Hall hall;
        Kitchen kitchen;

        Client client;
        Waiter waiter;
        Chef chef;

        [TestInitialize]
        public void TestInitialize()
        {
            hall = new Hall();
            kitchen = new Kitchen();

            client = hall.ListOfClients[0];
            waiter = (Waiter)hall.ListOfEmployees[0];
            chef = (Chef)kitchen.ListOfEmployees[0];
        }


        [TestMethod]
        public void MyTestMethod1()
        {
            client.TakeMenu(waiter.GiveMenu(1));
            Assert.AreEqual(true, client.Menu);
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            client.Eat();
            Assert.AreEqual(1, client.Hunger);
        }

        [TestCleanup]
        public void Cleanup()
        {
            hall = null;
            kitchen = null;
            client = null;
            waiter = null;
            chef = null;
        }

        [TestMethod]
        public void MyTestMethod4()
        {
            client.MakeOrder();
            waiter.GetOrder(client.ClientOrder);
            Assert.AreEqual(1, waiter.ListOfOrder.Count);
        }

        [TestMethod]
        public void MyTestMethod5()
        {
            client.MakeOrder();
            waiter.GetOrder(client.ClientOrder);
            chef.GetOrder(waiter.GiveOrder());
            chef.Cook();
            Assert.AreEqual(true, chef.ListOfOrder[0].OrderStatus);
        }

        [TestMethod]
        public void MyTestMethod6()
        {
            client.MakeOrder();
            waiter.GetOrder(client.ClientOrder);
            waiter.MakeBill();
            client.GetBill(waiter.GiveBill());
            client.Pay();
            Assert.AreEqual(30, client.Money);
        }
    }
}
