using System;

namespace InventorySystem
{
    public class MyMainClass
    {
        static void Main()
        {
            // Create a test instance of the Inventory Class, with  the constructor
            Inventory test = new Inventory();
            // Set the fields to new values
            test.QuantityOnHand = 104; test.QuantityOrdered = 500; test.ProductNumber = 01;
            test.ProductName = "Milk Carton"; test.PurchasePrice = 1.49; test.SellPrice = 3.99;

            // Call the methods
            double method1Test = test.CalculateRevenue();
            double method2Test = test.CalculateRevenue(150);
            double method3Test = test.ApplyDiscount(20);

            // Testing the class properties and methods by writing them to the console
            Console.WriteLine("Quantity on Hand: " + test.QuantityOnHand);
            Console.WriteLine("Quantity Ordered: " + test.QuantityOrdered);
            Console.WriteLine("Product Number: " + test.ProductNumber);
            Console.WriteLine("Product Name: " + test.ProductName);
            Console.WriteLine("Purchase Price: " + test.PurchasePrice);
            Console.WriteLine("Sell Price: " + test.SellPrice);
            Console.WriteLine("Calculate Revenue No Parameter:  " + method1Test);
            Console.WriteLine("Calculate Revenue with Parameter: " + method2Test);
            Console.WriteLine("Apply Discount: " + method3Test);

        }
    }
}
