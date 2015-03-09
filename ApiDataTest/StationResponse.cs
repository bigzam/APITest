using System;
using System.Runtime.Serialization;

namespace ApiDataTest
{
    [DataContract]
    public class StationResponse
    {
        [DataMember]
        public FuelStationRecord Alt_Fuel_Station { get; set; }
    }
}
