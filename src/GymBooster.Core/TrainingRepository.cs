using System;
using System.Collections.Generic;
using GymBooster.Core.Entities;

namespace GymBooster.Core
{
    public class TrainingRepository
    {
        public List<Training> GetAllTrainings()
        {
            var trainingStartTime = new DateTime(2016, 03, 12, 18, 0, 0);
            var training = new Training
            {
                StartTime = trainingStartTime,
                EndTime = trainingStartTime.AddHours(1)
            };
            training.AddExercises(new List<Exercise>
            {
                new Exercise
                {
                    Type = new ExcerciseType {Id = Guid.NewGuid(), Name = "Squat"},
                    Series = new List<ExcerciseSerie>
                    {
                        new ExcerciseSerie
                        {
                            StartTime = trainingStartTime.AddMinutes(1),
                            EndTime = trainingStartTime.AddMinutes(2),
                            NumberOfReps = 8,
                            WeightInKilos = 100
                        },
                        new ExcerciseSerie
                        {
                            StartTime = trainingStartTime.AddMinutes(5),
                            EndTime = trainingStartTime.AddMinutes(6),
                            NumberOfReps = 8,
                            WeightInKilos = 140
                        },
                        new ExcerciseSerie
                        {
                            StartTime = trainingStartTime.AddMinutes(10),
                            EndTime = trainingStartTime.AddMinutes(11),
                            NumberOfReps = 8,
                            WeightInKilos = 170
                        },
                        new ExcerciseSerie
                        {
                            StartTime = trainingStartTime.AddMinutes(15),
                            EndTime = trainingStartTime.AddMinutes(17),
                            NumberOfReps = 8,
                            WeightInKilos = 200
                        },
                    }
                }
            });
            return new List<Training> { training };
        }
    }
}
