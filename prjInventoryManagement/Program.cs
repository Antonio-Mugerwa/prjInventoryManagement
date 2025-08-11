using System.Security.Authentication.ExtendedProtection;
using CustomExtensionMethods;

namespace prjInventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare instance of objoct
            Product productGroup = new Product();
            //create anonymous type object of class (DEV, 2024)
            var product = new List<Product>
            {
                new Product
                {
                    id = 1,
                    name = "Shoes",
                    quantity = 10,
                    price = 500.00
                },
                new Product
                {
                    id = 2,
                    name = "pants",
                    quantity = 20,
                    price = 150.00

                },
                new Product
                {
                    id = 3,
                    name = "Shirts",
                    quantity = 30,
                    price = 250.00
                },
                new Product
                {
                    id = 4,
                    name = "Hats",
                    quantity = 0,
                    price = 50.00
                }
            };

            //LinQ to get name and  price (CSharpTutorial, 2024)
            var MyProductName = product.Select(p => p.name).ToList();
            var MyProductPrice = product.Select(p => p.price).ToList();

            //display 
            for(int x = 0; x < MyProductName.Count; x++)
            {
                Console.WriteLine($"Product name:  {MyProductName[x]} Price: {MyProductPrice[x]}");
            }

            //Display the total price using the extension method
            Console.WriteLine($"\nThe total price is: {productGroup.CalculateProductValue(product)}");
            
            //display the low stock item using the extension method
            Console.WriteLine($"\nThe product out of stock is: {productGroup.FilterLowStock(product)}");
        }
    }
}

//DEV, 2024. C# Advanced: Anonymous Types with LINQ. [Online] Available at < https://dev.to/moh_moh701/c-advanced-anonymous-types-with-linq-4co0 > [Accessed 11 August 2025].
//CSharpTutorial, 2024. LINQ Select. [Online] Available at < https://www.csharptutorial.net/csharp-linq/linq-select/ > [Accessed 11 August 2025