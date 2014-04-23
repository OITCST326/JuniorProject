#region Includes
using System;
using System.Collections.Generic;
using System.Text;
//using NUnit.Framework;
using AIM.Service.Administrative;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
//using System.ServiceModel;
using System.Threading.Tasks;
using AIM.Service.Entities.Models;
using TrackableEntities.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrackableEntities.EF6;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Service
// Module:       JobServiceTest.cs
// Description:  Tests for the Job Service class in the AIM. Service. Core assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:52 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace AIM.Service.AdministrativeTest
{

    /// <summary>
    /// Tests for the Job Service Class
    /// Documentation: 
    /// </summary>
    [TestClass]//, Description("Tests for Job Service")]
    public class JobServiceTest
    {
        #region Class Variables
        private JobServiceMock _jobService;
        #endregion

        #region Property Tests

        #region GeneratedProperties

        // No public properties were found. No tests are generated for non-public scoped properties.

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        #region GeneratedMethods

        /// <summary>
        /// Get Jobs List Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;IEnumerable&lt;Job&gt;&gt; GetJobsList()
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void GetJobsListTest()
        {
            JobServiceMock jobService = new JobServiceMock(); //Trial Mode
            //JobService jobService = new JobService("place user name here", "place license key here"); //License Mode

            Task<IEnumerable<Job>> results;

            //Parameters

            results = jobService.GetJobsList();
        }

        /// <summary>
        /// Get Job Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Job&gt; GetJob(int id)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void GetJobTest()
        {
            JobServiceMock jobService = new JobServiceMock(); //Trial Mode
            //JobService jobService = new JobService("place user name here", "place license key here"); //License Mode

            Task<Job> results;

            //Parameters
            int id = 123;

            results = jobService.GetJob(id);
        }

        /// <summary>
        /// Update Job Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Job&gt; UpdateJob(Job entity)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void UpdateJobTest()
        {
            JobServiceMock jobService = new JobServiceMock(); //Trial Mode
            //JobService jobService = new JobService("place user name here", "place license key here"); //License Mode

            Task<Job> results;

            //Parameters
            Job entity = new Job();

            results = jobService.UpdateJob(entity);
        }

        /// <summary>
        /// Create Job Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Job&gt; CreateJob(Job entity)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void CreateJobTest()
        {
            JobServiceMock jobService = new JobServiceMock(); //Trial Mode
            //JobService jobService = new JobService("place user name here", "place license key here"); //License Mode

            Task<Job> results;

            //Parameters
            Job entity = new Job();

            results = jobService.CreateJob(entity);
        }

        /// <summary>
        /// Delete Job Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;bool&gt; DeleteJob(int id)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void DeleteJobTest()
        {
            JobServiceMock jobService = new JobServiceMock(); //Trial Mode
            //JobService jobService = new JobService("place user name here", "place license key here"); //License Mode

            Task<bool> results;

            //Parameters
            int id = 123;

            results = jobService.DeleteJob(id);
        }

        /// <summary>
        /// Dispose Method Test
        /// Documentation   :  
        /// Method Signature:  void Dispose()
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void DisposeTest()
        {
            JobServiceMock jobService = new JobServiceMock(); //Trial Mode
            //JobService jobService = new JobService("place user name here", "place license key here"); //License Mode


            //Parameters

            jobService.Dispose();
        }

        #endregion // End of GeneratedMethods

        #endregion

    }
}
