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
// Module:       Applicant-JobServiceTest.cs
// Description:  Tests for the Applicant class in the Unknown Assembly Name assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:55 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace TrackableEntities.ModelsTest
{

    /// <summary>
    /// Tests for the Applicant Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Applicant")]
    public class ApplicantTest
    {
        #region Class Variables
        private Applicant _applicant;
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
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.ExtensionData = new System.Runtime.Serialization.ExtensionDataObject();
        }

        /// <summary>
        /// Applicant Question Answers Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.ApplicantQuestionAnswer[]
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void ApplicantQuestionAnswersTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.ApplicantQuestionAnswers = new TrackableEntities.Models.ApplicantQuestionAnswer[0];
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
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.Applications = new TrackableEntities.Models.Application[0];
        }

        /// <summary>
        /// Educations Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Education[]
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void EducationsTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.Educations = new TrackableEntities.Models.Education[0];
        }

        /// <summary>
        /// Hours Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Hour[]
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void HoursTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.Hours = new TrackableEntities.Models.Hour[0];
        }

        /// <summary>
        /// Job Histories Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.JobHistory[]
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void JobHistoriesTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.JobHistories = new TrackableEntities.Models.JobHistory[0];
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
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.ModifiedProperties = new string[20];
        }

        /// <summary>
        /// References Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Reference[]
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void ReferencesTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.References = new TrackableEntities.Models.Reference[0];
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
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.TrackingState = new TrackableEntities.TrackingState();
        }

        /// <summary>
        /// Users Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.User[]
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void UsersTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.Users = new TrackableEntities.Models.User[0];
        }

        /// <summary>
        /// answer Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void answerIDTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.answerID = new System.Nullable<int>();
        }

        /// <summary>
        /// applicant Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void applicantIDTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.applicantID = 123;
        }

        /// <summary>
        /// application Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void applicationIDTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.applicationID = new System.Nullable<int>();
        }

        /// <summary>
        /// education Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void educationIDTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.educationID = new System.Nullable<int>();
        }

        /// <summary>
        /// hours Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void hoursIDTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.hoursID = new System.Nullable<int>();
        }

        /// <summary>
        /// job History Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void jobHistoryIDTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.jobHistoryID = new System.Nullable<int>();
        }

        /// <summary>
        /// reference Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void referenceIDTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.referenceID = new System.Nullable<int>();
        }

        /// <summary>
        /// user Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void userIDTest()
        {
            Applicant applicant = new Applicant(); //Trial Mode
            //Applicant applicant = new Applicant("place user name here", "place license key here"); //License Mode

            applicant.userID = new System.Nullable<int>();
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
