using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_Vehicles_Demo.Logic.Contracts
{
    public interface ILandVehicle
    {
        void DriveTo(float latitude, float longitude);
    }
}
