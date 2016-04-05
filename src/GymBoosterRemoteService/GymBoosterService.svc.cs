using System.Collections.Generic;
using GymBooster.Core;
using GymBooster.Core.Entities;

namespace GymBoosterRemoteService
{
    public class GymBoosterService : IAmGymBoosterService
    {
        public List<Training> GetAllTrainings() => new TrainingRepository().GetAllTrainings();
    }
}
