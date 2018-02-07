namespace ParkingManagement.Models
{
    public class ParkingLot
    {
        public ParkingTypes ParkingType { get; set; }
        public ParkingSizes ParkingSize { get; set; }
        public int CurrentVehiclesCount { get; set; }
        public int MaxVehiclesCountSupported { get; set; }
    }

}
