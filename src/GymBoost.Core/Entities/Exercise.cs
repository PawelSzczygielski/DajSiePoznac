using System.Collections.Generic;

namespace GymBoost.Core.Entities
{
    public class Exercise
    {
        public Exercise()
        {

        }

        public ExcerciseType Type
        {
            get; set;
        }

        public List<ExcerciseSerie> Series { get; set; }
    }
}