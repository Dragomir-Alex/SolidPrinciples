using System.Collections.Generic;

namespace OpenClosedPrinciple_Museum_Strategy_Demo.Logic
{
    public class Museum
    {
        private readonly double _fullTicketPrice;
        private List<Person> _visitors;

        public double IncomeFromTickets { get; private set; }

        public Museum(double fullTicketPrice)
        {
            _visitors = new List<Person>();
            _fullTicketPrice = fullTicketPrice;
            IncomeFromTickets = 0;
        }

        public void Visit(Person person)
        {
            _visitors.Add(person);
            IncomeFromTickets += _fullTicketPrice * person.TicketType.PriceMultiplier;
        }
    }
}
