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
// Module:       Application-JobServiceTest.cs
// Description:  Tests for the Application class in the Unknown Assembly Name assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:55 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace TrackableEntities.ModelsTest
{

    /// <summary>
    /// Tests for the Application Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Application")]
    public class ApplicationTest
    {
        #region Class Variables
        private Application _application;
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
            Application application = new Application(); //Trial Mode
            //Application application = new Application("place user name here", "place license key here"); //License Mode

            application.ExtensionData = new System.Runtime.Serialization.ExtensionDataObject();
        }

        /// <summary>
        /// Applicant Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Applicant
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void ApplicantTest()
        {
            Application application = new Application(); //Trial Mode
            //Application application = new Application("place user name here", "place license key here"); //License Mode

            application.Applicant = new TrackableEntities.Models.Applicant();
        }

        /// <summary>
        /// Job Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Job
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void JobTest()
        {
            Application application = new Application(); //Trial Mode
            //Application application = new Application("place user name here", "place license key here"); //License Mode

            application.Job = new TrackableEntities.Models.Job();
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
            Application application = new Application(); //Trial Mode
            //Application application = new Application("place user name here", "place license key here"); //License Mode

            application.ModifiedProperties = new string[20];
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
            Application application = new Application(); //Trial Mode
            //Application application = new Application("place user name here", "place license key here"); //License Mode

            application.TrackingState = new TrackableEntities.TrackingState();
        }

        /// <summary>
        /// applicant Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void applicantIDTest()
        {
            Application application = new Application(); //Trial Mode
            //Application application = new Application("place user name here", "place license key here"); //License Mode

            application.applicantID = new System.Nullable<int>();
        }

        /// <summary>
        /// application Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void applicationIDTest()
        {
            Application application = new Application(); //Trial Mode
            //Application application = new Application("place user name here", "place license key here"); //License Mode

            application.applicationID = 123;
        }

        /// <summary>
        /// date Created Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.DateTime&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void dateCreatedTest()
        {
            Application application = new Application(); //Trial Mode
            //Application application = new Application("place user name here", "place license key here"); //License Mode

            application.dateCreated = new System.Nullable<System.DateTime>();
        }

        /// <summary>
        /// job Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void jobIDTest()
        {
            Application application = new Application(); //Trial Mode
            //Application application = new Application("place user name here", "place license key here"); //License Mode

            application.jobID = new System.Nullable<int>();
        }

        /// <summary>
        /// pre Employment Statement Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void preEmploymentStatementTest()
        {
            Application application = new Application(); //Trial Mode
            //Application application = new Application("place user name here", "place license key here"); //License Mode

            application.preEmploymentStatement = "test";
        }

        /// <summary>
        /// status Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void statusTest()
        {
            Application application = new Application(); //Trial Mode
            //Application application = new Application("place user name here", "place license key here"); //License Mode

            application.status = 123;
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
