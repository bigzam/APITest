using System;
using System.Runtime.Serialization;

namespace ApiDataTest
{
    [DataContract]
    public class PrecisionRecord
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Value { get; set; }
        [DataMember]
        public string[] Types { get; set; }
    }
}
