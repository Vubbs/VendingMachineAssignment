using Assignment4_VendingMachine;
using Assignment4_VendingMachine.Classes;
namespace VendingMachineTests
{
    [TestClass]
    public class VendingMachineTest
    {
        [TestMethod]
        public void ReturnedCorrectAmount()
        {
            int expected = 0;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.MoneyPool = 100;

            vendingMachine.ReturnMoney();
            int actual = vendingMachine.MoneyPool;
            Assert.AreEqual(expected, actual, 0.001, "Money not returned correctly");
        }
        [TestMethod]
        public void RightProductDelivered()
        {
            int expected = 15;

            VendingMachine vendingMachine1 = new VendingMachine();
            vendingMachine1.AddProducts();
            vendingMachine1.MoneyPool = 100;
            vendingMachine1.BuyProduct(15);

            int actual = vendingMachine1.UserProducts[0].ProductID;
            Assert.AreEqual(expected, actual, 1,"Wrong item is delivered.");
            
        }
        [TestMethod]
        public void ReduceMoneyByRightAmount()
        {
            int expected = 80;

            VendingMachine vendingMachine1 = new VendingMachine();
            vendingMachine1.AddProducts();
            vendingMachine1.MoneyPool = 100;
            vendingMachine1.BuyProduct(15);

            int actual = vendingMachine1.MoneyPool;
            Assert.AreEqual(expected, actual, 1, "Wrong amount is deducted.");
        }
        [TestMethod]
        public void UsedProductsRemoved() 
        {
            int expected = 0;

            VendingMachine vendingMachine1 = new VendingMachine();
            vendingMachine1.AddProducts();
            vendingMachine1.MoneyPool = 100;
            vendingMachine1.BuyProduct(15);
            vendingMachine1.UseProduct(15);

            Assert.AreEqual(expected, vendingMachine1.UserProducts.Count,0.001, "Used product not removed from user.");
        }
    }
}