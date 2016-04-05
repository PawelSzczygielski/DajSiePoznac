using System;
using System.Runtime.Serialization;

namespace GymBooster.Core.Entities
{
    [DataContract]
    public class ExcerciseType
    {
        public ExcerciseType()
        {
        }

        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}