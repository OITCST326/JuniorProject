﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ServiceModel;
using System.Threading.Tasks;
using AIM.Service.Entities.Models;
using TrackableEntities.Common;
using TrackableEntities.EF6;

// NOTE: Add Trackable Entities EF Nuget package, then reference 
// Trackable Service Entities project and System.ServiceModel.

namespace AIM.Service.Administrative
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IJobService
    {
        [OperationContract]
        Task<IEnumerable<Job>> GetJobsList();

        [OperationContract]
        Task<Job> GetJob(int id);

        [OperationContract]
        Task<Job> UpdateJob(Job entity);

        [OperationContract]
        Task<Job> CreateJob(Job entity);

        [OperationContract]
        Task<bool> DeleteJob(int id);
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class JobService : IJobService, IDisposable
    {
        private readonly AIM_DBContext _dbContext;

        public JobService()
        {
            _dbContext = new AIM_DBContext();
        }

        public async Task<IEnumerable<Job>> GetJobsList()
        {
            IEnumerable<Job> entities = await _dbContext.Jobs
                .Include(j => j.Hour)
                .Include(j => j.Questionnaire)
                .ToListAsync();
            return entities;
        }

        public async Task<Job> GetJob(int id)
        {
            Job entity = await _dbContext.Jobs
                .SingleOrDefaultAsync(x => x.jobId == id);
            return entity;
        }

        public async Task<Job> UpdateJob(Job entity)
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

        public async Task<Job> CreateJob(Job entity)
        {
            _dbContext.Jobs.Add(entity);
            await _dbContext.SaveChangesAsync();
            entity.AcceptChanges();
            return entity;
        }

        public async Task<bool> DeleteJob(int id)
        {
            Job entity = await _dbContext.Jobs
                .SingleOrDefaultAsync(x => x.jobId == id);
            if (entity == null)
                return false;

            try
            {
                _dbContext.Jobs.Attach(entity);
                _dbContext.Jobs.Remove(entity);
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