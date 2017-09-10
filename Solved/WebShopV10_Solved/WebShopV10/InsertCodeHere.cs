using System;
using System.Collections.Generic;

namespace WebShopV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<double> itemPriceList1 = new List<double> { 12.0, 20.0, 75.0, 44.0, 15.0, 49.0 };
            Order theOrder = new Order(itemPriceList1);
            Console.WriteLine($"Order (org) total cost is : {theOrder.TotalOrderPrice:F2} kr.");

            List<double> itemPriceList2 = new List<double> { 12.0, 20.0, 75.0, 44.0, 15.0, 49.0 };
            OrderV2 theOrderV2 = new OrderV2(itemPriceList2);
            Console.WriteLine($"Order (V2)  total cost is : {theOrderV2.TotalOrderPrice:F2} kr.");

            List<double> itemPriceList3 = new List<double> { 12.0, 20.0, 75.0, 44.0, 15.0, 49.0 };
            OrderV3 theOrderV3 = new OrderV3(itemPriceList3);
            Console.WriteLine($"Order (V3)  total cost is : {theOrderV3.TotalOrderPrice:F2} kr.");

            // The LAST line of code should be ABOVE this line
        }
    }
}