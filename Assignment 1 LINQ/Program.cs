using System.Runtime.Intrinsics.Arm;
using System.Threading;
using System.Xml.Linq;

namespace Assignment_1_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Find all products that are out of stock.

            //var outOfStockProducts = ListGenerator.ProductsList
            //                          .Where(p => p.UnitsInStock == 0);

            //foreach (var product in outOfStockProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName} is out of stock.");
            //}
            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var expensiveProducts = ListGenerator.ProductsList
            //                         .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00);

            //foreach (var product in expensiveProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice}");
            //}

            #endregion
            #region 1. Get first Product out of Stock 

            //var firstOutOfStockProduct = ListGenerator.ProductsList
            //                              .FirstOrDefault(p => p.UnitsInStock == 0);

            //Console.WriteLine($"First out of stock product: {firstOutOfStockProduct?.ProductName ?? "None"}");

            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var expensiveProduct = ListGenerator.ProductsList
            //                        .FirstOrDefault(p => p.UnitPrice > 1000);

            //Console.WriteLine($"Expensive product: {expensiveProduct?.ProductName ?? "None"}");

            #endregion
            #region Produce a sequence of the uppercase
            //var sortedByPrice = ListGenerator.ProductsList.OrderBy(p => p.UnitPrice);

            //foreach (var product in sortedByPrice)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice}");
            //}

            #endregion
            #region Produce a sequence of the lowercase
            //var sortedByStock = ListGenerator.ProductsList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var product in sortedByStock)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //}

            #endregion
            #region 
            //var totalStock = ListGenerator.ProductsList.Sum(p => p.UnitsInStock);

            //Console.WriteLine($"Total stock across all products: {totalStock}");

            #endregion
            #region 3. Return a list of categories and how many products each has

            //var categoryCounts = ListGenerator.ProductsList.GroupBy(p => p.Category)
            //                 .Select(g => new { Category = g.Key, Count = g.Count() });

            //foreach (var group in categoryCounts)
            //{
            //    Console.WriteLine($"Category: {group.Category}, Count: {group.Count}");
            //}

            #endregion
            #region 6. Select all orders where the order total is less than 500.00.

            //var smallOrders = ListGenerator.CustomersList.SelectMany(c => c.Orders)
            //                                 .Where(o => o.Total < 500);

            //foreach (var order in smallOrders)
            //{
            //    Console.WriteLine($"Order {order.OrderID} has total {order.Total}");
            //}

            #endregion
            #region 7. Select all orders where the order was made in 1998 or later.
            //var recentOrders = ListGenerator.CustomersList.SelectMany(c => c.Orders)
            //                                  .Where(o => o.OrderDate.Year >= 1998);

            //foreach (var order in recentOrders)
            //{
            //    Console.WriteLine($"Order {order.OrderID} was made on {order.OrderDate}");
            //}

            #endregion
            #region 2. Return a list of customers and how many orders each has.
            //foreach (var customer in ListGenerator.CustomersList)
            //{
            //    Console.WriteLine($"Customer: {customer.CustomerName}");

            //    foreach (var order in customer.Orders)
            //    {
            //        Console.WriteLine($"\t{order}");
            //    }
            //}

            #endregion
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.string[] Arr = {“zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine”};
            //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var shortNamedNumbers = arr.Where((name, index) => name.Length < index);

            //foreach (var num in shortNamedNumbers)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
            #region 3. Retrieve the second number greater than 5  Int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int[] arrNumbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var secondNumberGreaterThanFive = arrNumbers.Where(n => n > 5)
            //                                            .OrderBy(n => n)
            //                                            .Skip(1)
            //                                            .FirstOrDefault();

            //Console.WriteLine($"Second number greater than 5: {secondNumberGreaterThanFive}");
            #endregion
            #region 1. Uses Count to get the number of odd numbers in the array Int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddNumbersCount = arrNumbers.Count(n => n % 2 != 0);
            //Console.WriteLine($"Count of odd numbers: {oddNumbersCount}");
            #endregion

        }
    }
}
