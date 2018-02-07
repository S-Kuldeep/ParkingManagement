using System.Collections.Generic;
using ParkingManagement.Models;

namespace ParkingManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkedVehicleses=new List<ParkedVehicles>();
            var smallVehicle = new Vehicle {VehicleType = VehicleTypes.Small};

            parkedVehicleses.Add(new ParkedVehicles(smallVehicle));

            var medVehicle = new Vehicle { VehicleType = VehicleTypes.Med };

            parkedVehicleses.Add(new ParkedVehicles(medVehicle));

            var largeVehicle = new Vehicle { VehicleType = VehicleTypes.Large };

            parkedVehicleses.Add(new ParkedVehicles(largeVehicle));

        }
    }
}
