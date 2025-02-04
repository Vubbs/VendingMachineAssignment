namespace Assignment4_VendingMachine.Classes
{
    public class Drinks : Products
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductInfo { get; set; }
        public int ProductID { get; set; }

        public Drinks(string productName, int productPrice, string productInfo, int productID)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ProductInfo = productInfo;
            ProductID = productID;
        }
    }
}
