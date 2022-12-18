using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability_Orders_Demo.Logic
{
    public class CreditCardDetails
    {
        public string CardNumber { get; private set; }
        public string CardholderName { get; private set; }
        public int ExpiresMonth { get; private set; }
        public int ExpiresYear { get; private set; }

        public CreditCardDetails(string cardNumber, string cardholderName, int expiresMonth, int expiresYear)
        {
            CardNumber = cardNumber;
            CardholderName = cardholderName;
            ExpiresMonth = expiresMonth;
            ExpiresYear = expiresYear;
        }
    }
}
