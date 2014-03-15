using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using AIM.Client.Entities.Models;

// Use this example as a guide for copying the service contract from Service.Core
// after adding a Trackable WCF Service Type.


namespace AIM.ConsoleClient
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IJobService
    {
        [OperationContract(Name = "GetJobsList")]
        Task<IEnumerable<Job>> GetJobsListAsync();

        [OperationContract(Name = "GetJob")]
        Task<Job> GetJobAsync(int id);

        [OperationContract(Name = "UpdateJob")]
        Task<Job> UpdateJobAsync(Job entity);

        [OperationContract(Name = "CreateJob")]
        Task<Job> CreateJobAsync(Job entity);

        [OperationContract(Name = "DeleteJob")]
        Task<bool> DeleteJobAsync(int id);
    }
}
