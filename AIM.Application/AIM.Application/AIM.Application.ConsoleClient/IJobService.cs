using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using AIM.Application.Client.Entities.Models;

namespace AIM.Application.ConsoleClient
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IJobService
    {
        [OperationContract(Name = "GetOpenJobsList")]
        Task<IEnumerable<OpenJob>> GetOpenJobsListAsync();

        [OperationContract(Name = "GetStoreList")]
        Task<IEnumerable<Store>> GetStoreListAsync();

        [OperationContract(Name = "GetJobsList")]
        Task<IEnumerable<Job>> GetJobsListAsync();        

        [OperationContract(Name = "GetJob")]
        Task<Job> GetJobAsync(int? id);

        [OperationContract(Name = "UpdateJob")]
        Task<Job> UpdateJobAsync(Job entity);

        [OperationContract(Name = "CreateJob")]
        Task<Job> CreateJobAsync(Job entity);

        [OperationContract(Name = "DeleteJob")]
        Task<bool> DeleteJobAsync(int id);
    }
}
