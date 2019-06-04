﻿using System;
using DependencyInjection_Orders_End.Logic.Carts;
using DependencyInjection_Orders_End.Logic.Contracts;
using DependencyInjection_Orders_End.Logic.Exceptions;
using DependencyInjection_Orders_End.Logic.Inventories;

namespace DependencyInjection_Orders_End.Logic.Implementations
{
    public class ReservationService : IReservationService
    {
        public void ReserveInventory(Cart cart)
        {
            var inventorySystem = new InventorySystem();
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
