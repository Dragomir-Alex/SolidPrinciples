using SingleResponsability_Orders_Demo.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability_Orders_Demo.Logic.OrderTypes
{
    public class POSCreditCardOrder : Order
    {
        private readonly CreditCardDetails creditCardDetails;
        private readonly PaymentService paymentService;
        private readonly InventoryService inventoryService;

        public POSCreditCardOrder(Cart cart, Customer customer, CreditCardDetails paymentDetails) : base(cart, customer)
        {
            creditCardDetails = paymentDetails;
            inventoryService = new InventoryService();
            paymentService = new PaymentService();
        }

        public override void Checkout()
        {
            paymentService.ChargeCard(creditCardDetails, cart);
            inventoryService.ReserveInventory(cart);
        }
    }
}
