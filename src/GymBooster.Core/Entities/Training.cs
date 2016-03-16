using System;
using System.Collections.Generic;

namespace GymBooster.Core.Entities
{
    public class Training
    {
        public Training()
        {
            Exercises = new List<Exercise>();
        }

        public List<Exercise> Exercises { get; }

        public DateTime StartTime { get;  set; }
        public DateTime EndTime { get; set; }

        public void AddExercises(IEnumerable<Exercise> exercises)
        {
            Exercises.AddRange(exercises);
        }
    }
}
