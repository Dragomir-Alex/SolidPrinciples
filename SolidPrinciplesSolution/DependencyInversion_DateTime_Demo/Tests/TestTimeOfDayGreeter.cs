﻿using DependencyInversion_DateTime_Demo.Logic;
using Moq;
using NUnit.Framework;

namespace DependencyInversion_DateTime_Demo.Tests
{
    [TestFixture]
    public class TestTimeOfDayGreeter
    {
        private static string name = "Nadia";

        [Test]
        public void TimeOfDayGreeting_GetProperGreeting_WithMorningTime_Success()
        {
            // arrange
            var greeter = new TimeOfDayGreeter(new DateTimeProvider());

            // act
            var greeting = greeter.GetProperGreeting(name);

            // assert
            Assert.IsTrue(greeting.Contains(name));
        }

        [Test]
        public void TimeOfDayGreeting_GetProperGreeting_WithAfternoonTime_Success()
        {
            // arrange
            var greeter = new TimeOfDayGreeter(new DateTimeProvider());

            // act
            var greeting = greeter.GetProperGreeting(name);

            // assert
            Assert.IsTrue(greeting.Contains(name));
        }

        [Test]
        public void TimeOfDayGreeting_GetProperGreeting_WithEveningTime_Success()
        {
            // arrange
            var greeter = new TimeOfDayGreeter(new DateTimeProvider());

            // act
            var greeting = greeter.GetProperGreeting(name);

            // assert
            Assert.IsTrue(greeting.Contains(name));
        }
    }
}
