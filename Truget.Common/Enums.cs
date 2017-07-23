using System;

namespace Truget.Common
{
    public static class Enums
    {
        public enum TruckType : short
        {
            Open = 0,
            Close,
            Pickup,
            Box,
            Flatbed,
            MobileCrane,
            Dump,
            LogCarrier,
            Refrigerator,
            TractorUnit,
            Tank,
            BallastTractor,
            Haul
        }

        public enum TruckSize : short
        {
            Light = 0,
            Medium,
            Heavy,
            VeryHeavy
        }
    }
}
