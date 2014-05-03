#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AIM.Service.Administrative;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ServiceModel;
using System.Threading.Tasks;
using TrackableEntities.EF6;
using TrackableEntities.Common;
using AIM.Service.Entities.Models;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Service
// Module:       PersonlInfoServiceTest.cs
// Description:  Tests for the Personl Info Service class in the AIM. Service. Core assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:52 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace AIM.Service.AdministrativeTest
{

    /// <summary>
    /// Tests for the Personl Info Service Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Personl Info Service")]
    public class PersonlInfoServiceTest
    {
        #region Class Variables
        private PersonlInfoService _personlInfoService;
        #endregion

        #region Property Tests

        #region GeneratedProperties

        // No public properties were found. No tests are generated for non-public scoped properties.

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        #region GeneratedMethods

        /// <summary>
        /// Get Personal Infoes Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;IEnumerable&lt;PersonalInfo&gt;&gt; GetPersonalInfoes()
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetPersonalInfoesTest()
        {
            PersonlInfoService personlInfoService = new PersonlInfoService(); //Trial Mode
            //PersonlInfoService personlInfoService = new PersonlInfoService("place user name here", "place license key here"); //License Mode

            Task<IEnumerable<PersonalInfo>> results;

            //Parameters

            results = personlInfoService.GetPersonalInfoes();
        }

        /// <summary>
        /// Get Personal Info Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;PersonalInfo&gt; GetPersonalInfo(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetPersonalInfoTest()
        {
            PersonlInfoService personlInfoService = new PersonlInfoService(); //Trial Mode
            //PersonlInfoService personlInfoService = new PersonlInfoService("place user name here", "place license key here"); //License Mode

            Task<PersonalInfo> results;

            //Parameters
            int id = 123;

            results = personlInfoService.GetPersonalInfo(id);
        }

        /// <summary>
        /// Update Personal Info Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;PersonalInfo&gt; UpdatePersonalInfo(PersonalInfo entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void UpdatePersonalInfoTest()
        {
            PersonlInfoService personlInfoService = new PersonlInfoService(); //Trial Mode
            //PersonlInfoService personlInfoService = new PersonlInfoService("place user name here", "place license key here"); //License Mode

            Task<PersonalInfo> results;

            //Parameters
            PersonalInfo entity = new PersonalInfo();

            results = personlInfoService.UpdatePersonalInfo(entity);
        }

        /// <summary>
        /// Create Personal Info Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;PersonalInfo&gt; CreatePersonalInfo(PersonalInfo entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void CreatePersonalInfoTest()
        {
            PersonlInfoService personlInfoService = new PersonlInfoService(); //Trial Mode
            //PersonlInfoService personlInfoService = new PersonlInfoService("place user name here", "place license key here"); //License Mode

            Task<PersonalInfo> results;

            //Parameters
            PersonalInfo entity = new PersonalInfo();

            results = personlInfoService.CreatePersonalInfo(entity);
        }

        /// <summary>
        /// Delete Personal Info Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;bool&gt; DeletePersonalInfo(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void DeletePersonalInfoTest()
        {
            PersonlInfoService personlInfoService = new PersonlInfoService(); //Trial Mode
            //PersonlInfoService personlInfoService = new PersonlInfoService("place user name here", "place license key here"); //License Mode

            Task<bool> results;

            //Parameters
            int id = 123;

            results = personlInfoService.DeletePersonalInfo(id);
        }

        /// <summary>
        /// Dispose Method Test
        /// Documentation   :  
        /// Method Signature:  void Dispose()
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void DisposeTest()
        {
            PersonlInfoService personlInfoService = new PersonlInfoService(); //Trial Mode
            //PersonlInfoService personlInfoService = new PersonlInfoService("place user name here", "place license key here"); //License Mode


            //Parameters

            personlInfoService.Dispose();
        }

        #endregion // End of GeneratedMethods

        #endregion

    }
}
