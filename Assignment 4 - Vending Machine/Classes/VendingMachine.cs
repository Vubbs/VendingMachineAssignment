using System.Runtime.CompilerServices;
using static System.Console;
[assembly: InternalsVisibleTo("VendingMachineTest")]
namespace Assignment4_VendingMachine.Classes
{
    public class VendingMachine
    {
        public enum MoneyInput
        {
            A = 1,
            B = 5,
            C = 20,
            D = 50,
            E = 100,
            F = 500,
            G = 1000,
        }
        public int MoneyPool { get; set; }
        public List<Drinks> Drinks { get; set; }
        public List<Snacks> Snacks { get; set; }
        public List<Sandwiches> Sandwiches { get; set; }
        public List<Products> UserProducts { get; set; }
        public List<Products> Products { get; set; }

        public VendingMachine()
        {
            Drinks = new List<Drinks> { };
            Snacks = new List<Snacks> { };
            Sandwiches = new List<Sandwiches> { };
            Products = new List<Products> { };
            UserProducts = new List<Products> { };

        }
        public void UseProduct(int pID)
        {
            foreach (var i in UserProducts.ToList())
            {
                if (pID == i.ProductID && pID <= 11) // check if ID is matching -- also if ID is 11 or under (all drinks are id 1 - 11)
                {
                    WriteLine($"You drank the {i.ProductName}, and disposed the drink in the trashcan next to the vending machine.");
                    UserProducts.Remove(i);
                    break;
                }
                else if (pID == i.ProductID && pID >= 12 && pID <= 20) // check if ID is matching -- also if ID is 12 or over and 20 or under(all snacks are id 12 - 20)
                {
                    WriteLine($"You ate the {i.ProductName}, and disposed the wrapping in the trashcan next to the vending machine.");
                    UserProducts.Remove(i);
                    break;
                }
                else
                    WriteLine("You tried to eat or drink something you don't have!");
            }
        }
        public void BuyProduct(int pID)
        {
            foreach (var i in Products)
            {
                if (pID == i.ProductID) // check if id is matching
                {
                    if (MoneyPool - i.ProductPrice < 0)  // check if user has sufficient money
                    {
                        WriteLine("You don't have sufficient money for this item.");
                        ReadKey();
                        Clear();
                        break;
                    }
                    MoneyPool -= i.ProductPrice;         // deduct money
                    WriteLine($"You successfully bought {i.ProductName}");
                    UserProducts.Add(i);                 // give user product
                    WriteLine($"You have {MoneyPool}kr balance left.");
                }
            }
        }
        public void ExamineProduct(int pID)
        {
            foreach (var i in Products)
            {
                if (pID == i.ProductID)  // check if id is matching
                {
                    Clear();
                    WriteLine("Product information");
                    WriteLine($"ID: {i.ProductID}\nName: {i.ProductName}\nPrice: {i.ProductPrice}\nDescription: {i.ProductInfo}");
                }
            }
        }
        public void AddMoney(MoneyInput moneyInput)
        {
            MoneyPool += (int)moneyInput; // adds money to the pool
        }
        public void ReturnMoney()
        {
            WriteLine($"Your change is {MoneyPool}kr and has been returned.");
            MoneyPool -= MoneyPool;       // "returns" the money (simulated by just removing it)
        }
        public void AddDrinks(Drinks product)
        {
            Drinks.Add(product);          // adds the drink to both a drinks list and a full products list
            Products.Add(product);
        }
        public void AddSnacks(Snacks product)
        {
            Snacks.Add(product);          // adds the snacks to both a snacks list and a full products list
            Products.Add(product);
        }
        public void AddSandwiches(Sandwiches product)
        {
            Sandwiches.Add(product);      // adds the sandwiches to both a sandwiches list and a full products list
            Products.Add(product);
        }
        public void AddProducts()
        {
            // Adds products to the vending machine -- drinks, snacks and sandwiches seperated for easier reading and if wanted, adding
            Drinks water = new Drinks("Regular Water", 20, "500ml PET bottle of plain uncarbonated water.", 1); // (Name, Price, Description, ID)
            AddDrinks(water);                                                                                   // call the method for adding product to the right lists
            Drinks carbonatedWater = new Drinks("Carbonated Water", 20, "500ml PET bottle of plain carbonated water", 2);
            AddDrinks(carbonatedWater);
            Drinks cola = new Drinks("Coca Cola", 30, "500ml PET bottle of Coca Cola", 3);
            AddDrinks(cola);
            Drinks colaZero = new Drinks("Coca Cola Zero", 30, "500ml PET bottle of Coca Cola Zero", 4);
            AddDrinks(colaZero);
            Drinks pepsi = new Drinks("Pepsi Cola", 25, "500ml PET bottle of Pepsi", 5);
            AddDrinks(pepsi);
            Drinks pepsiMax = new Drinks("Pepsi Max", 25, "500ml PET bottle of Pepsi Max", 6);
            AddDrinks(pepsiMax);
            Drinks fanta = new Drinks("Fanta Orange", 30, "500ml PET bottle of Fanta", 7);
            AddDrinks(fanta);
            Drinks fantaLemon = new Drinks("Fanta Lemon", 30, "500ml PET bottle of Fanta Lemon", 8);
            AddDrinks(fantaLemon);
            Drinks orangeJuice = new Drinks("Orange Juice", 35, "500ml PET bottle of fresh Orange Juice", 9);
            AddDrinks(orangeJuice);
            Drinks iceCoffee = new Drinks("Iced Coffee", 28, "33cl Can of Iced Coffee", 10);
            AddDrinks(iceCoffee);
            Drinks iceCaffeLatte = new Drinks("Iced Caffe Latte", 30, "33cl Can of Iced Caffe Latte, contains milk", 11);
            AddDrinks(iceCaffeLatte);

            Snacks granolaBar = new Snacks("Granola Bar", 15, "80g Granola Bar, contains nuts, chocolate, sugar, raisins", 12);
            AddSnacks(granolaBar);
            Snacks saltedChips = new Snacks("Lightly Salted Chips", 20, "95g bag of Lightly Salted Potato Chips, contains potato, salt, oil", 13);
            AddSnacks(saltedChips);
            Snacks sourcreamChips = new Snacks("Sourcream & Onion Chips", 20, "95g bag of Sourcream & Onion Potato Chips, contains potato, salt, onion granulates, dried sourcream granulates, oil", 14);
            AddSnacks(sourcreamChips);
            Snacks chocolateBar = new Snacks("Chocolate Bar", 20, "100g Chocolate Bar, contains, sugar, coconutoil, cocoa (may contain nuts)", 15);
            AddSnacks(chocolateBar);

            Sandwiches cheeseSandwich = new Sandwiches("Sandwich with Cheese", 20, "75g Sandwich with Cheese, contains plain white bread(gluten), butter(lactose), cheese", 16);
            AddSandwiches(cheeseSandwich);
            Sandwiches cheeseHamSandwich = new Sandwiches("Sandwich with Cheese & Ham", 25, "85g Sandwich with Cheese & Ham, contains plain white bread(gluten), butter(lactose), cheese, ham", 17);
            AddSandwiches(cheeseHamSandwich);
            Sandwiches bltSandwich = new Sandwiches("BLT Sandwich", 30, "90g BLT Sandwich, contains plain white bread(gluten), mayonnaise(eggs), lettuce, tomato, bacon", 18);
            AddSandwiches(bltSandwich);
            Sandwiches chickenCurrySandwich = new Sandwiches("Sandwich with Chicken & Curry", 35, "100g Sandwich with Chicken & Curry, contains plain white bread(gluten), curry mayonnaise(eggs), lettuce, chicken", 19);
            AddSandwiches(chickenCurrySandwich);
            Sandwiches vegetableSandwich = new Sandwiches("Sandwich with Vegetables", 28, "75g Sandwich with Vegetables, contains plain white bread(gluten), vegan butter, lettuce, cucumber, bell pepper, Tomato", 20);
            AddSandwiches(vegetableSandwich);
        }
    }
}
