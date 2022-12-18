using OpenClosedPrinciple_Museum_Strategy_Demo.Logic.Tickets;

namespace OpenClosedPrinciple_Museum_Strategy_Demo.Logic
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Ticket TicketType { get; private set; }

        public Person(string name, int age, Ticket ticketType)
        {
            Name = name;
            Age = age;
            TicketType = ticketType;
        }
    }
}
