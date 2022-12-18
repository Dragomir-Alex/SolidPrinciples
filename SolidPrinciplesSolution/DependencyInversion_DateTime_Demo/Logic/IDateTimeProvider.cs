using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_DateTime_Demo.Logic
{
    public interface IDateTimeProvider
    {
        DateTime GetDateNow();
    }
}
