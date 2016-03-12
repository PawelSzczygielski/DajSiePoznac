using System;
using System.Collections.Generic;

namespace GymBoost.Core.Entities
{
    public class Training
    {
        public Training()
        {
            _exercises = new List<Exercise>();
        }

        private readonly List<Exercise> _exercises;

        public DateTime StartTime { get;  set; }
        public DateTime EndTime { get; set; }

        public void AddExercises(IEnumerable<Exercise> exercises)
        {
            _exercises.AddRange(exercises);
        }
    }
}
