using System;
using System.Runtime.Serialization;

namespace GymBooster.Core.Entities
{
    [DataContract]
    public class ExcerciseSerie
    {
        [DataMember]
        public int NumberOfReps { get; set; }
        [DataMember]
        public double WeightInKilos { get; set; }
        [DataMember]
        public DateTime StartTime { get; set; }
        [DataMember]
        public DateTime EndTime { get; set; }
    }
}