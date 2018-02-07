using System;

namespace ParkingManagement.Models
{
    class ParkedVehicles
    {
        public ParkedVehicles(Vehicle vehicle)
        {
            _vehicle = vehicle;
            _allotedParkingSlot = ParkingManager.AllocateParking(vehicle);

        }
        private Guid _token;
        private ParkingLot _allotedParkingSlot;
        private Vehicle _vehicle;

        public Guid Token
        {
            get { return _token; }
            private set
            {
                _token = Guid.NewGuid();
            }
        }

        
    }
}
