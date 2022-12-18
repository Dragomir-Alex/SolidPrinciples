using System;
using OpenClosedPrinciple_Museum_Strategy_Demo.Logic;
using OpenClosedPrinciple_Museum_Strategy_Demo.Logic.Tickets;

namespace OpenClosedPrinciple_Museum_Strategy_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Museum museum = new Museum(5);

            museum.Visit(new Person("Mehmet Sultanul", 4, new ChildTicket()));
            museum.Visit(new Person("Cristina Pop", 6, new AdultTicket()));
            museum.Visit(new Person("Rafael Popescu", 20, new SeniorTicket()));
            museum.Visit(new Person("Nadia Comanici", 33, new ChildTicket()));
            museum.Visit(new Person("Mihai Lungu", 83, new AdultTicket()));

            Console.WriteLine($"The museum's income from tickets: {museum.IncomeFromTickets}");
        }
    }
}
