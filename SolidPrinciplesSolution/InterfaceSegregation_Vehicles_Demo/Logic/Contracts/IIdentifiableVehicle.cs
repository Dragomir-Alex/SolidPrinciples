using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_Vehicles_Demo.Logic.Contracts
{
    public interface IIdentifiableVehicle : ISpeedableVehicle
    {
        string LicencePlate { get; }
        Coordinate3D CurrentLocation { get; }
    }
}
