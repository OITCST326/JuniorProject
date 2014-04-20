using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using AIM.Client.Entities.Models;

namespace AIM.ConsoleClient
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IPersonalInfoService
    {
        [OperationContract(Name = "GetPersonalInfoList")]
        Task<IEnumerable<PersonalInfo>> GetPersonalInfoList();

        [OperationContract(Name = "GetPersonalInfo")]
        Task<PersonalInfo> GetPersonalInfo(int id);

        [OperationContract(Name = "UpdatePersonalInfo")]
        Task<PersonalInfo> UpdatePersonalInfo(PersonalInfo entity);

        [OperationContract(Name = "CreatePersonalInfo")]
        Task<PersonalInfo> CreatePersonalInfo(PersonalInfo entity);

        [OperationContract(Name = "DeletePersonalInfo")]
        Task<bool> DeletePersonalInfo(int id);
    }
}
