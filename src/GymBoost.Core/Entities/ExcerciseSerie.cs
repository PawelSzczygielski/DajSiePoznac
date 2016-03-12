using System;

namespace GymBoost.Core.Entities
{
    public class ExcerciseSerie
    {
        public int NumberOfReps { get; set; }

        public double WeightInKilos { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}