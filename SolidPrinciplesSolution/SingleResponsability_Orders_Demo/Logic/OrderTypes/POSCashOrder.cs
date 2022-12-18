using SingleResponsability_Orders_Demo.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability_Orders_Demo.Logic.OrderTypes
{
    public class POSCashOrder : Order
    {
        private readonly InventoryService inventoryService;

        public POSCashOrder(Cart cart, Customer customer) : base(cart, customer)
        {
            inventoryService = new InventoryService();
        }

        public override void Checkout()
        {
            inventoryService.ReserveInventory(cart);
        }
    }
}
