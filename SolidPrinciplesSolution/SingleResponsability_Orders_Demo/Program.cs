using System;
using SingleResponsability_Orders_Demo.Logic;
using SingleResponsability_Orders_Demo.Logic.OrderTypes;

namespace SingleResponsability_Orders_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();
            cart.Items.Add(new CartItem(24, 1));
            cart.Items.Add(new CartItem(101, 2));
            cart.Items.Add(new CartItem(44, 1));
            cart.Items.Add(new CartItem(82, 1));
            cart.Items.Add(new CartItem(75, 3));

            var customer = new Customer("Nadia", "Comanici", "nadia@email.com");

            var creditCardDetails = new CreditCardDetails(
                "ABCD 1234 ABCD 1234 ABCD 1234",
                "Nadia C",
                1,
                2020
                );

            // WebSite
            Console.WriteLine("1. Website order:");
            var onlineOrder = new OnlineOrder(cart, customer, creditCardDetails);
            onlineOrder.Checkout();
            Console.WriteLine();

            // POS Credit Card
            Console.WriteLine("2. POS Credit Card order:");
            var posCreditCardOrder = new POSCreditCardOrder(cart, customer, creditCardDetails);
            posCreditCardOrder.Checkout();
            Console.WriteLine();

            // POS Cash
            Console.WriteLine("3. POS Cash order:");
            var posCashOrder = new POSCashOrder(cart, customer);
            posCashOrder.Checkout();
            Console.WriteLine();
        }
    }
}
