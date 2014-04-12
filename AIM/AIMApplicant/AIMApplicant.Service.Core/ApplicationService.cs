using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ServiceModel;
using System.Threading.Tasks;
using TrackableEntities.EF6;
using TrackableEntities.Common;
using AIMApplicant.Service.Entities.Models;

// NOTE: Add Trackable Entities EF Nuget package, then reference 
// Trackable Service Entities project and System.ServiceModel.

namespace AIMApplicant.Service.Core
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IApplicationService
    {
        [OperationContract]
        Task<IEnumerable<Application>> GetApplications();

        [OperationContract]
        Task<Application> GetApplication(int id);

        [OperationContract]
        Task<Application> UpdateApplication(Application entity);

        [OperationContract]
        Task<Application> CreateApplication(Application entity);

        [OperationContract]
        Task<bool> DeleteApplication(int id);
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ApplicationService : IApplicationService, IDisposable
    {
        private readonly AIM_DBContext _dbContext;

        public ApplicationService()
        {
            _dbContext = new AIM_DBContext();
        }

        public async Task<IEnumerable<Application>> GetApplications()
        {
            IEnumerable<Application> entities = await _dbContext.Applications
                .ToListAsync();
            return entities;
        }

        public async Task<Application> GetApplication(int id)
        {
            Application entity = await _dbContext.Applications
                .SingleOrDefaultAsync(x => x.applicationId == id);
            return entity;
        }

        public async Task<Application> UpdateApplication(Application entity)
        {
            try
            {
                _dbContext.ApplyChanges(entity);
                await _dbContext.SaveChangesAsync();
                entity.AcceptChanges();
                return entity;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        public async Task<Application> CreateApplication(Application entity)
        {
            _dbContext.Applications.Add(entity);
            await _dbContext.SaveChangesAsync();
            entity.AcceptChanges();
            return entity;
        }

        public async Task<bool> DeleteApplication(int id)
        {
            Application entity = await _dbContext.Applications
                .SingleOrDefaultAsync(x => x.applicationId == id);
            if (entity == null)
                return false;

            try
            {
                _dbContext.Applications.Attach(entity);
                _dbContext.Applications.Remove(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        public void Dispose()
        {
            var dispose = _dbContext as IDisposable;
            if (dispose != null)
            {
                _dbContext.Dispose();
            }
        }
    }
}
