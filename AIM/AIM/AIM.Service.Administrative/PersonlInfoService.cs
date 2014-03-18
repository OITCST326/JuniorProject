using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ServiceModel;
using System.Threading.Tasks;
using TrackableEntities.EF6;
using TrackableEntities.Common;
using AIM.Service.Entities.Models;

namespace AIM.Service.Administrative
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IPersonlInfoService
    {
        [OperationContract]
        Task<IEnumerable<PersonalInfo>> GetPersonalInfoes();

        [OperationContract]
        Task<PersonalInfo> GetPersonalInfo(int id);

        [OperationContract]
        Task<PersonalInfo> UpdatePersonalInfo(PersonalInfo entity);

        [OperationContract]
        Task<PersonalInfo> CreatePersonalInfo(PersonalInfo entity);

        [OperationContract]
        Task<bool> DeletePersonalInfo(int id);
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class PersonlInfoService : IPersonlInfoService, IDisposable
    {
        private readonly AIM_DBContext _dbContext;

        public PersonlInfoService()
        {
            _dbContext = new AIM_DBContext();
        }

        public async Task<IEnumerable<PersonalInfo>> GetPersonalInfoes()
        {
            IEnumerable<PersonalInfo> entities = await _dbContext.PersonalInfoes
                .ToListAsync();
            return entities;
        }

        public async Task<PersonalInfo> GetPersonalInfo(int id)
        {
            PersonalInfo entity = await _dbContext.PersonalInfoes
                .SingleOrDefaultAsync(x => x.PersonalInfoId == id);
            return entity;
        }

        public async Task<PersonalInfo> UpdatePersonalInfo(PersonalInfo entity)
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

        public async Task<PersonalInfo> CreatePersonalInfo(PersonalInfo entity)
        {
            _dbContext.PersonalInfoes.Add(entity);
            await _dbContext.SaveChangesAsync();
            entity.AcceptChanges();

            return entity;
        }

        public async Task<bool> DeletePersonalInfo(int id)
        {
            PersonalInfo entity = await _dbContext.PersonalInfoes
                .SingleOrDefaultAsync(x => x.PersonalInfoId == id);
            if (entity == null)
                return false;

            try
            {
                _dbContext.PersonalInfoes.Attach(entity);
                _dbContext.PersonalInfoes.Remove(entity);
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
