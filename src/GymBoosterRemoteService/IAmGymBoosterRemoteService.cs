using System.Collections.Generic;
using System.ServiceModel;
using GymBooster.Core.Entities;

namespace GymBoosterRemoteService
{
    [ServiceContract]
    public interface IAmGymBoosterService
    {

        [OperationContract]
        List<Training> GetAllTrainings();
    }
}
