using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment4_VendingMachine;
using Assignment4_VendingMachine.Classes;
using System;

namespace Vending_Machine_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReduceMoneyByRightAmount()
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.MoneyPool = 100;

            vendingMachine.ReturnMoney();
            int actual = vendingMachine.MoneyPool;
            Assert.AreEqual(expected, actual, 0.001, "Money not returned correctly.";
        }
    }
}
