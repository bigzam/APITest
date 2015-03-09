using System;
using System.Runtime.Serialization;


namespace ApiDataTest
{
    [DataContract]
    public class FeredarlAgencyRecord
    {
        [DataMember]
        public int Id { get; set;}

        [DataMember]
        public string Name { get; set; }
    }
}
