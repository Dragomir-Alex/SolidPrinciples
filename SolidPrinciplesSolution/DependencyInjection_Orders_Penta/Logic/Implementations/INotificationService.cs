﻿using DependencyInjection_Orders_Penta.Logic.Carts;

namespace DependencyInjection_Orders_Penta.Logic.Implementations
{
    public interface INotificationService
    {
        void NotifyCustomer(Cart cart, Customer customer);
    }
}