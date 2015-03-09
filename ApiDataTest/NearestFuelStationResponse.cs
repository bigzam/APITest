using System;
using System.Runtime.Serialization;

namespace ApiDataTest
{
    [DataContract]
    public class NearestFuelStationResponse
    {
        [DataMember]
        public FuelStationRecord[] Fuel_Stations { get; set; }
        [DataMember]
        public decimal Latitude { get; set; }
        [DataMember]
        public decimal Longitude { get; set; }

        [DataMember]
        public int Offset { get; set; }

        [DataMember]
        public PrecisionRecord Precision { get; set; }
        [DataMember]
        public string Station_Locator_Url { get; set; }
        [DataMember]
        public int Total_Results { get; set; }

    }
}
