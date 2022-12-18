using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple_Museum_Strategy_Demo.Logic.Tickets
{
    public class AdultTicket : Ticket
    {
        public double PriceMultiplier
        {
            get
            {
                return 1;
            }
        }
    }
}
