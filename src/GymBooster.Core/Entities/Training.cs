using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GymBooster.Core.Entities
{
    [DataContract]
    public class Training
    {
        public Training()
        {
            Exercises = new List<Exercise>();
        }

        [DataMember]
        public List<Exercise> Exercises { get; }

        [DataMember]
        public DateTime StartTime { get;  set; }

        [DataMember]
        public DateTime EndTime { get; set; }

        public void AddExercises(IEnumerable<Exercise> exercises)
        {
            Exercises.AddRange(exercises);
        }
    }
}
