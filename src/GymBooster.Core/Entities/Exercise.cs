using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GymBooster.Core.Entities
{
    [DataContract]
    public class Exercise
    {
        public Exercise()
        {
        }

        [DataMember]
        public ExcerciseType Type
        {
            get; set;
        }

        [DataMember]
        public List<ExcerciseSerie> Series { get; set; }
    }
}