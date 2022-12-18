using SingleResponsability_Orders_Demo.Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability_Orders_Demo.Logic.Services
{
    public class InventoryService
    {
        private readonly InventorySystem inventorySystem;

        public InventoryService()
        {
            inventorySystem = new InventorySystem();
        }
        public void ReserveInventory(Cart cart)
        {
            Console.WriteLine("ReserveInventory");
            foreach (var item in cart.Items)
            {
                try
                {
                    inventorySystem.Reserve(item.Id, item.Quantity);
                }
                catch (InsufficientInventoryException)
                {
                    throw new OrderException($"Insufficient available items for {item.Id}");
                }
                catch (Exception)
                {
                    throw new OrderException($"Problems reserving {item.Id}");
                }
            }
        }
    }
}
