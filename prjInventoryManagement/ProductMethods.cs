using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using prjInventoryManagement;

namespace CustomExtensionMethods //Changed namespace to ExtensionMethods (TutorialsTeacher, 2024).
{
    public static class ProductMethods //changed the class to public static
    {
        //extension method to calculate total 
        public static double CalculateProductValue(this Product product, List<Product> productList) //use 'this'to denote extension method (Learn.Microsoft, 2025).
        {
            double total = 0.00;

            //loop through List to total the product price
            for(int i = 0; i < productList.Count(); i++)
            {
                total = total + productList[i].price; //(StackOverflow 2009)
            }

            return total;
        }

        //extension method to find low stock
        public static string FilterLowStock(this Product product, List<Product> productList)
        {
            string lowStock = "";

            //loop through List to find all stock that are 'low'
            for (int i = 0; i < productList.Count(); i++)
            {
                if(productList[i].quantity == 0)
                {
                    lowStock += productList[i].name + "/n";
                }
            }

            return "Products low on stock are: " + lowStock;

        }
    }
}
//Tutorials, 2024. C# - Extension Method. [Online] Available at: < https://www.tutorialsteacher.com/csharp/csharp-extension-method > [Accessed 8 August 2025]
//Learn.Micrososft, 2025. Extension members (C# Programming Guide). [Online] Available at: < https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods > [Accessed 8 August 2025].
//StackOverflow, 2009. Finding an item in a List<> using C#. [Online] Available at < https://stackoverflow.com/questions/1485766/finding-an-item-in-a-list-using-c-sharp > [Accessed 10 August 2025].