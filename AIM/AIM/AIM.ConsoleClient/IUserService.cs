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
    public interface IUserService
    {
        [OperationContract(Name = "GetUsersList")]
        Task<IEnumerable<User>> GetUsersListAsync();

        [OperationContract(Name = "GetUser")]
        Task<User> GetUserAsync(int id);

        [OperationContract(Name = "UpdateUser")]
        Task<User> UpdateUserAsync(User entity);

        [OperationContract(Name = "CreateUser")]
        Task<User> CreateUserAsync(User entity);

        [OperationContract(Name = "DeleteUser")]
        Task<bool> DeleteUserAsync(int id);
    }
}
