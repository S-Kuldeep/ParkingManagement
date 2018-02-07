namespace ParkingManagement.Models
{
    static class ParkingManager
    {
        private static readonly ParkingLot SmallparkingLot;
        private static readonly ParkingLot MedparkingLot;
        private static readonly ParkingLot LargeparkingLot;

        static ParkingManager()
        {
            SmallparkingLot=new ParkingLot()
                                 {
                                     MaxVehiclesCountSupported=10,
                                     ParkingSize = ParkingSizes.Small,
                                     ParkingType = ParkingTypes.Regular
                                 };

            MedparkingLot=new ParkingLot()
            {
                MaxVehiclesCountSupported = 20,
                ParkingSize = ParkingSizes.Med,
                ParkingType = ParkingTypes.Compact
            };

            LargeparkingLot=new ParkingLot()
            {
                MaxVehiclesCountSupported = 30,
                ParkingSize = ParkingSizes.Large,
                ParkingType = ParkingTypes.Reserved
            };
        }
        public static ParkingLot AllocateParking(Vehicle parkedvehicle)
        {
            if (parkedvehicle.VehicleType==VehicleTypes.Small)
            {
                ParkingLot allocateParking;
                if (AllocateSmallParking(out allocateParking)) 
                    return allocateParking;
            }

            if (parkedvehicle.VehicleType == VehicleTypes.Med)
            {
                ParkingLot medparkingLot;
                if (AllocateMediumParking(out medparkingLot))
                    return medparkingLot;
            }

            if (parkedvehicle.VehicleType == VehicleTypes.Large)
            {
                ParkingLot largeparkingLot1;
                if (AllocateLargeParking(out largeparkingLot1)) 
                    return largeparkingLot1;
            }
            return null;
        }

        private static bool AllocateLargeParking(out ParkingLot largeparkingLot1)
        {
            if (LargeparkingLot.CurrentVehiclesCount < LargeparkingLot.MaxVehiclesCountSupported)
            {
                LargeparkingLot.CurrentVehiclesCount++;
                {
                    largeparkingLot1 = LargeparkingLot;
                    return true;
                }
            }
            return false;
        }

        private static bool AllocateMediumParking(out ParkingLot medparkingLot)
        {
            if (MedparkingLot.CurrentVehiclesCount < MedparkingLot.MaxVehiclesCountSupported)
            {
                MedparkingLot.CurrentVehiclesCount++;
                {
                    medparkingLot = MedparkingLot;
                    return true;
                }
            }
            if (LargeparkingLot.CurrentVehiclesCount < LargeparkingLot.MaxVehiclesCountSupported)
            {
                LargeparkingLot.CurrentVehiclesCount++;
                {
                    medparkingLot = LargeparkingLot;
                    return true;
                }
            }
            return false;
        }

        private static bool AllocateSmallParking(out ParkingLot allocateParking)
        {
            if (SmallparkingLot.CurrentVehiclesCount < SmallparkingLot.MaxVehiclesCountSupported)
            {
                SmallparkingLot.CurrentVehiclesCount++;
                {
                    allocateParking = SmallparkingLot;
                    return true;
                }
            }
            if (MedparkingLot.CurrentVehiclesCount < MedparkingLot.MaxVehiclesCountSupported)
            {
                MedparkingLot.CurrentVehiclesCount++;
                {
                    allocateParking = MedparkingLot;
                    return true;
                }
            }
            if (LargeparkingLot.CurrentVehiclesCount < LargeparkingLot.MaxVehiclesCountSupported)
            {
                LargeparkingLot.CurrentVehiclesCount++;
                {
                    allocateParking = LargeparkingLot;
                    return true;
                }
            }
            return false;
        }
    }
}
