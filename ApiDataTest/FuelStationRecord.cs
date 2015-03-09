using System;
using System.Runtime.Serialization;

namespace ApiDataTest
{
    [DataContract]
    public class FuelStationRecord
    {
        [DataMember]
        public string Fuel_Type_Code { get; set; }
        [DataMember]
        public string Station_Name { get; set; }
        [DataMember]
        public string Street_Address { get; set; }
        [DataMember]
        public string Intersection_Directions{ get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string Zip { get; set; }
        [DataMember]
        public string Plus4 { get; set; }
        [DataMember]
        public string Station_Phone { get; set; }
        [DataMember]
        public string Status_Code{ get; set; }

        [DataMember]
        public string Expected_Date{ get; set; }
        [DataMember]
        public string Groups_With_Access_Code{ get; set; }
        [DataMember]
        public string Access_Days_Time{ get; set; }
        [DataMember]
        public string Cards_Accepted { get; set; }
        [DataMember]
        public string Owner_Type_Code{ get; set; }
        [DataMember]
        public FeredarlAgencyRecord Federal_Agency{ get; set; }

        [DataMember]
        public string BD_Blends { get; set; }

        [DataMember]
        public bool? E85_Blender_Pump { get; set; }

        [DataMember]
        public bool? LPG_Primary { get; set; }

        [DataMember]
        public string NG_Fill_Type_Code { get; set; }

        [DataMember]
        public string NG_Psi { get; set; }

        [DataMember]
        public string NG_Vehicle_Class{ get; set; }
        [DataMember(EmitDefaultValue = true)]
        public int? EV_Level1_EVSE_Num{ get; set; }
        [DataMember]
        public int? EV_Level2_EVSE_Num { get; set; }

        [DataMember]
        public int? EV_DC_Fast_Num { get; set; }
        [DataMember]
        public string EV_Other_EVSE { get; set; }
        [DataMember]
        public string EV_Network { get; set; }
        [DataMember]
        public string EV_Network_Web { get; set; }
        [DataMember]
        public string[] EV_connector_types{ get; set; }
        [DataMember]
        public string Hy_Status_Link { get; set; }
        [DataMember]
        public string Geocode_Status { get; set; }
        [DataMember]
        public string Latitude { get; set; }
        [DataMember]
        public decimal? Longitude { get; set; }
        [DataMember]
        public string Open_Date { get; set; }
        [DataMember]
        public string Date_Last_Confirmed { get; set; }
        [DataMember]
        public string Updated_At { get; set; }
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public decimal? Distance { get; set; }
    }
}
