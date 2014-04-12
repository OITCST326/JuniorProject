using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using AIMApplicant.Client.Entities.Models;

// Use this example as a guide for copying the service contract from Service.Core
// after adding a Trackable WCF Service Type.


namespace AIMApplicant.ConsoleClient
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IExampleService
    {
        [OperationContract(Name = "GetApplications")]
        Task<IEnumerable<Application>> GetApplicationsAsync();

        [OperationContract(Name = "GetApplication")]
        Task<Application> GetApplicationAsync(int id);

        [OperationContract(Name = "UpdateApplication")]
        Task<Application> UpdateApplicationAsync(Application entity);

        [OperationContract(Name = "CreateApplication")]
        Task<Application> CreateApplicationAsync(Application entity);

        [OperationContract(Name = "DeleteApplication")]
        Task<bool> DeleteApplicationAsync(int id);
    }
}
