#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TrackableEntities.Models;
using System.Runtime.Serialization;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Models
// Module:       Job-UserServiceTest.cs
// Description:  Tests for the Job class in the Unknown Assembly Name assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:55 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace TrackableEntities.ModelsTest
{

    /// <summary>
    /// Tests for the Job Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Job")]
    public class JobTest
    {
        #region Class Variables
        private Job _job;
        #endregion

        #region Property Tests

        #region GeneratedProperties

        /// <summary>
        /// Extension Data Property Test
        /// Documentation:  
        /// Property Type:  System.Runtime.Serialization.ExtensionDataObject
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void ExtensionDataTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.ExtensionData = new System.Runtime.Serialization.ExtensionDataObject();
        }

        /// <summary>
        /// Applications Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Application[]
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void ApplicationsTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.Applications = new TrackableEntities.Models.Application[0];
        }

        /// <summary>
        /// Employees Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Employee[]
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void EmployeesTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.Employees = new TrackableEntities.Models.Employee[0];
        }

        /// <summary>
        /// Hour Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Hour
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void HourTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.Hour = new TrackableEntities.Models.Hour();
        }

        /// <summary>
        /// Modified Properties Property Test
        /// Documentation:  
        /// Property Type:  string[]
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void ModifiedPropertiesTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.ModifiedProperties = new string[20];
        }

        /// <summary>
        /// Questionnaire Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Questionnaire
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void QuestionnaireTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.Questionnaire = new TrackableEntities.Models.Questionnaire();
        }

        /// <summary>
        /// Tracking State Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.TrackingState
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void TrackingStateTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.TrackingState = new TrackableEntities.TrackingState();
        }

        /// <summary>
        /// description Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void descriptionTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.description = "test";
        }

        /// <summary>
        /// full Part Time Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void fullPartTimeTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.fullPartTime = "test";
        }

        /// <summary>
        /// job Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void jobIDTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.jobID = 123;
        }

        /// <summary>
        /// operating Hours Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void operatingHoursIDTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.operatingHoursID = new System.Nullable<int>();
        }

        /// <summary>
        /// position Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void positionTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.position = "test";
        }

        /// <summary>
        /// questionnaire Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void questionnaireIDTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.questionnaireID = new System.Nullable<int>();
        }

        /// <summary>
        /// salary Range Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void salaryRangeTest()
        {
            Job job = new Job(); //Trial Mode
            //Job job = new Job("place user name here", "place license key here"); //License Mode

            job.salaryRange = "test";
        }

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        #region GeneratedMethods

        // No methods were found. No tests are generated for methods.

        #endregion // End of GeneratedMethods

        #endregion

    }
}
