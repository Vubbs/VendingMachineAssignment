using Assignment4_VendingMachine.Classes;
using static Assignment4_VendingMachine.Classes.VendingMachine;
using static System.Console;
namespace Assignment4_VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine machine = new VendingMachine();      // makes the VendingMachine object
            machine.AddProducts();                              // adds all the products
            try                                                 // try/catch to catch any errors
            {
                while (true)                                    // make everything inside a loop
                {
                    Clear();
                    WriteLine("Vending Machine containing Drinks and a small selection of Snacks and Sandwiches.");
                    WriteLine("1. List of Drinks to buy");
                    WriteLine("2. List of Snacks to buy");
                    WriteLine("3. List of Sandwiches to buy");
                    WriteLine("4. Add or Return Money");

                    if (machine.UserProducts.Count > 0)         // Shows only if user has bought a product
                        WriteLine("5. Use bought products.");

                    WriteLine();

                    if (machine.MoneyPool > 0)                  // Show balance if user has added money
                        WriteLine($"Current balance: {machine.MoneyPool}kr");

                    if (machine.UserProducts.Count > 0)         // Shows only if user has bought a product
                        Write("Choose an option (1-5) or 0 to exit: ");

                    else                                        // Else shows this (the default)
                        Write("Choose an option (1-4) or 0 to exit: ");

                    int option = int.Parse(ReadLine());         // Navigation Input
                    if (option == 0)                            // if '0' is input then exit the loop (exiting the program)
                        break;

                    if (option != 1 && option != 2 && option != 3 && option != 4 && option != 5)   // if a wrong option is input, tell user
                    {
                        WriteLine("That is not a valid option.");
                        WriteLine("Press any key to continue.");
                        ReadKey();
                        continue;
                    }

                    switch (option)
                    {
                        case 1:
                            Clear();
                            foreach (var i in machine.Drinks)           // list all drinks
                            {
                                WriteLine($"ID: {i.ProductID}\tProduct: {i.ProductName}      \tPrice: {i.ProductPrice} kr");
                            }

                            WriteLine($"Your current balance is {machine.MoneyPool}kr");
                            WriteLine("Do you want to:\n1. Buy a Drink\n2. Examine a Drink");
                            Write("Enter 1 or 2 (0 to go back to previous menu): ");

                            int buyDrink = int.Parse(ReadLine());  
                            if (buyDrink == 0)                     
                                break;

                            if (buyDrink != 1 && buyDrink != 2)   
                            {
                                WriteLine("That is not a valid option.");
                                WriteLine("Press any key to continue.");
                                ReadKey();
                                continue;
                            }

                            switch (buyDrink)
                            {
                                case 1:
                                    if (machine.MoneyPool < 20)   // cheapest drink is 20kr, if user has under 20kr tell user money is not enough
                                    {
                                        WriteLine("You don't have enough money to buy any drinks.");
                                        ReadKey();
                                        break;
                                    }

                                    else
                                        Write("Write ID of item you want to buy: ");

                                    int pID = int.Parse(ReadLine());
                                    machine.BuyProduct(pID);
                                    break;
                                case 2:
                                    WriteLine("What item do you want to examine?");
                                    Write("Enter Product ID: ");

                                    int pID2 = int.Parse(ReadLine());
                                    machine.ExamineProduct(pID2);
                                    ReadKey();
                                    break;
                            }
                            break;
                        case 2:
                            Clear();
                            foreach (var i in machine.Snacks)               // list all snacks
                            {
                                WriteLine($"ID: {i.ProductID}\tProduct: {i.ProductName}      \tPrice: {i.ProductPrice} kr");
                            }

                            WriteLine($"Your current balance is {machine.MoneyPool}kr");
                            WriteLine("Do you want to:\n1. Buy a Snack\n2. Examine a Snack");
                            Write("Enter 1 or 2 (0 to go back to previous menu): ");

                            int buySnack = int.Parse(ReadLine());
                            if (buySnack == 0)
                                break;

                            if (buySnack != 1 && buySnack != 2)
                            {
                                WriteLine("That is not a valid option.");
                                WriteLine("Press any key to continue.");
                                ReadKey();
                                continue;
                            }

                            switch (buySnack)
                            {
                                case 1:
                                    if (machine.MoneyPool < 15)              // cheapest snack is 15kr, if user has under 15kr tell user money is not enough
                                    {
                                        WriteLine("You don't have enough money to buy any snacks.");
                                        ReadKey();
                                        break;
                                    }

                                    else
                                        Write("Write ID of item you want to buy: ");

                                    int pID = int.Parse(ReadLine());
                                    machine.BuyProduct(pID);
                                    ReadKey();
                                    break;
                                case 2:
                                    WriteLine("What item do you want to examine?");
                                    Write("Enter Product ID: ");

                                    int pID2 = int.Parse(ReadLine());
                                    machine.ExamineProduct(pID2);
                                    ReadKey();
                                    break;
                            }
                            break;
                        case 3:
                            Clear();
                            foreach (var i in machine.Sandwiches)
                            {
                                WriteLine($"ID: {i.ProductID}\tProduct: {i.ProductName}      \tPrice: {i.ProductPrice} kr");
                            }

                            WriteLine($"Your current balance is {machine.MoneyPool}kr");
                            WriteLine("Do you want to:\n1. Buy a Drink\n2. Examine a Drink");
                            Write("Enter 1 or 2 (0 to go back to previous menu): ");

                            int buySandwich = int.Parse(ReadLine());
                            if (buySandwich == 0)
                                break;

                            if (buySandwich != 1 && buySandwich != 2)
                            {
                                WriteLine("That is not a valid option.");
                                WriteLine("Press any key to continue.");
                                ReadKey();
                                continue;
                            }

                            switch (buySandwich)
                            {
                                case 1:
                                    if (machine.MoneyPool < 20) // cheapest sandwich is 20kr, if user has under 20kr tell user money is not enough
                                    {
                                        WriteLine("You don't have enough money to buy any sandwiches.");
                                        ReadKey();
                                        break;
                                    }

                                    else
                                        Write("Write ID of item you want to buy: ");

                                    int pID = int.Parse(ReadLine());
                                    machine.BuyProduct(pID);
                                    ReadKey();
                                    break;
                                case 2:
                                    WriteLine("What item do you want to examine?");
                                    Write("Enter Product ID: ");

                                    int pID2 = int.Parse(ReadLine());
                                    machine.ExamineProduct(pID2);
                                    ReadKey();
                                    break;
                            }
                            break;
                        case 4:
                            Clear();
                            WriteLine("1. Add Money");
                            WriteLine("2. Return Money");
                            WriteLine("\n0. Go back to previous menu");
                            Write("Choose an option (1, 2 or 0): ");

                            option = int.Parse(ReadLine());
                            if (option == 0)
                                break;

                            if (option != 1 && option != 2)
                            {
                                WriteLine("That is not a valid option.");
                                WriteLine("Press any key to continue.");
                                ReadKey();
                                continue;
                            }

                            switch (option)
                            {
                                case 1:
                                    while (true)
                                    {
                                        Clear();
                                        WriteLine("You can add money in these values:");
                                        WriteLine("A: 1kr\nB: 5kr\nC: 20kr\nD: 50kr\nE: 100kr\nF: 500kr\nG: 1000kr");

                                        if (machine.MoneyPool > 0)    // shows balance if balance exists
                                            WriteLine($"\nCurrent balance: {machine.MoneyPool}kr");

                                        else
                                            WriteLine("\nYou have currently no money added.");  

                                        WriteLine("How much would you like to add?");
                                        Write("Press A, B, C, D, E, F or G: ");

                                        MoneyInput addMoney;                                               // make enum MoneyInput named addMoney
                                        if (Enum.TryParse<MoneyInput>(ReadLine().ToUpper(), out addMoney)) // make sure an available value is entered (returns true or false)
                                        {                                                                  // if true (available value is entered) add the money
                                            machine.AddMoney(addMoney);                                    // 
                                            WriteLine($"\nCurrent Balance: {machine.MoneyPool}kr");
                                            WriteLine("\n\nPress 'y' to continue adding more money.");
                                            WriteLine("Press any key to stop adding money.");
                                            string addMore = ReadLine().ToLower();                         
                                            if (addMore != "y")                                            // if not 'y' is entered break the loop and go back to the menu
                                                break;
                                        }

                                        else                                                               // if false tell user it's not a valid option
                                        {
                                            WriteLine("That is not a valid option.");
                                            WriteLine("Press any key to continue.");
                                            ReadKey();
                                            continue;
                                        }
                                    }
                                    break;
                                case 2:
                                    machine.ReturnMoney(); 
                                    ReadKey();
                                    break;
                            }
                            break;
                        case 5:
                            Clear();
                            if (machine.UserProducts.Count == 1)                        // if user only has one item bought use correct grammar
                                WriteLine("This is your current bought product");

                            if (machine.UserProducts.Count > 1)                         // if user har more than one ----
                                WriteLine("These are your current bought products");

                            foreach (var i in machine.UserProducts)
                            {
                                WriteLine($"ID: {i.ProductID}\tProduct: {i.ProductName}");
                            }

                            WriteLine("\nDo you want to:\n1.Drink/Eat one of your bought products\n2. Examine one of your bought products");
                            Write("\nEnter 1 or 2 (0 to go back to previous menu): ");

                            int useProduct = int.Parse(ReadLine());
                            if (useProduct == 0)
                                break;

                            if (useProduct != 1 && useProduct != 2)
                            {
                                WriteLine("That is not a valid option.");
                                WriteLine("Press any key to continue.");
                                ReadKey();
                                continue;
                            }

                            switch (useProduct)
                            {
                                case 1:
                                    WriteLine("What product do you want to consume?");
                                    Write("Enter Product ID: ");

                                    int pID = int.Parse(ReadLine());
                                    machine.UseProduct(pID);
                                    ReadKey();
                                    break;
                                case 2:
                                    WriteLine("What item do you want to examine?");
                                    Write("Enter Product ID: ");

                                    int pID2 = int.Parse(ReadLine());
                                    machine.ExamineProduct(pID2);
                                    ReadKey();
                                    break;
                            }
                            break;
                    }
                }
                if (machine.MoneyPool > 0) // if loop is exited with money left, return money to user
                {
                    machine.ReturnMoney();
                    ReadKey();
                }
                if (machine.UserProducts.Count > 0) // if products are left on user write message
                {
                    WriteLine("You left some product(s) in the vending machine, how unfortunate!");
                    ReadKey();
                }
            }
            catch (Exception e) { WriteLine(e.Message); }
            Write("Press any key to exit.");
            ReadKey();
        }
    }
}
