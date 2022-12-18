using System;

namespace DependencyInversion_DateTime_Demo.Logic
{
    public class TimeOfDayGreeter
    {
        private readonly IDateTimeProvider dateTimeProvider;

        public TimeOfDayGreeter(IDateTimeProvider dateTimeProvider)
        {
            this.dateTimeProvider = dateTimeProvider;
        }

        public string GetProperGreeting(string name)
        {
            var now = dateTimeProvider.GetDateNow();
            if (now.Hour < 12)
            {
                return $"Good morning, {name}";
            }
            else
            {
                if (now.Hour < 18)
                {
                    return $"Good afternoon, {name}";
                }
                else
                {
                    return $"Good evening, {name}";
                }
            }
        }
    }
}
