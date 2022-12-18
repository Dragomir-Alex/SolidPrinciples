using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability_Orders_Demo.Logic.Services
{
    public class NotificationService
    {
        public void NotifyCustomer(Cart cart, Customer customer)
        {
            Console.WriteLine("NotifyCustomer");
            if (!string.IsNullOrEmpty(customer.Email))
            {
                // send email
            }
        }
    }
}
