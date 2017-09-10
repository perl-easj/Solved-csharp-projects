using System;

namespace WebShopV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            int noOfBooksInOrder = 8;
            int noOfDVDsInOrder = 3;
            int noOfGamesInOrder = 2;

            // I have chosen a style where each part of the total price is
            // calculated explicitly. All parts are then added up.

            double taxPercentage = 10.0;
            double creditCardFeePercentage = 2.0;


            double netPriceForAllItems = netPriceBook * noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder +
                                         netPriceGame * noOfGamesInOrder;

            double taxForAllItems = netPriceForAllItems * (taxPercentage / 100);

            double shippingForAllItems = 49;

            double creditCardFeeForAllItems = (netPriceForAllItems + taxForAllItems + shippingForAllItems) *
                                              (creditCardFeePercentage / 100);

            double totalPrice = netPriceForAllItems + taxForAllItems + shippingForAllItems + creditCardFeeForAllItems;

            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");


            // EXTRA (Step 4) - Calculation of discount
            //
            int totalNoOfItems = noOfDVDsInOrder + noOfBooksInOrder + noOfGamesInOrder;

            // discount5 is 1 if totalNoOfItems is at least 15, otherwise 0
            int discount5 = (totalNoOfItems / 15) - ((totalNoOfItems - 15) / 15);

            // discount10 is 1 if totalNoOfItems is at least 30, otherwise 0
            int discount10 = (totalNoOfItems / 30) - ((totalNoOfItems - 30) / 30);

            // Calculate the total discount percentage
            double discountPercentage = 5.0 * (discount5 + discount10);

            // Uncomment the below lines to see price with discount
            // totalPrice = totalPrice * (1 - 0.05*(discount5 + discount10));
            // Console.WriteLine($"Total cost with discount: {totalPrice} kr.");

            // The LAST line of code should be ABOVE this line
        }
    }
}