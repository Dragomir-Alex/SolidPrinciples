using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_DateTime_Demo.Logic
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDateNow()
        {
            return DateTime.Now;
        }
    }
}
