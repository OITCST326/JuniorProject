#region Includes
using System;
using System.Collections.Generic;
using System.Text;
//using NUnit.Framework;
//using AIM.Service.Entities.Models;
using AIM.Client.Entities.Models;
using TrackableEntities;
using TrackableEntities.Common;
using TrackableEntities.Client;
//using TrackableEntities
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Models
// Module:       EducationTest.cs
// Description:  Tests for the Education class in the Unknown Assembly Name assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:55 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace TrackableEntities.ModelsTest
{

    /// <summary>
    /// Tests for the Education Class
    /// Documentation: 
    /// </summary>
    [TestClass]//, Description("Tests for Education")]
    public class EducationTest
    {
        #region Class Variables
        private Education _education;
        #endregion

        #region Property Tests

        #region GeneratedProperties

        /// <summary>
        /// Extension Data Property Test
        /// Documentation:  
        /// Property Type:  System.Runtime.Serialization.ExtensionDataObject
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void ExtensionDataTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode

         //   education.ExtensionData = new System.Runtime.Serialization.ExtensionDataObject();
        }

        /// <summary>
        /// Applicant Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Applicant
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void ApplicantTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode

            //education.Applicant = new TrackableEntities.Models.Applicant();
            education.Applicant = new AIM.Client.Entities.Models.Applicant();
        }

        /// <summary>
        /// Modified Properties Property Test
        /// Documentation:  
        /// Property Type:  string[]
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void ModifiedPropertiesTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode

            education.ModifiedProperties = new string[20];
        }

        /// <summary>
        /// Tracking State Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.TrackingState
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void TrackingStateTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode

            education.TrackingState = new TrackableEntities.TrackingState();
        }

        /// <summary>
        /// applicant Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void applicantIDTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode
            education.applicantId = new System.Nullable<int>();
           // education.applicantID = new System.Nullable<int>();
        }

        /// <summary>
        /// city Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void cityTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode

            education.city = "test";
        }

        /// <summary>
        /// degree Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void degreeTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode

            education.degree = "test";
        }

        /// <summary>
        /// education Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void educationIDTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode
            education.educationId = 123;
            //education.educationID = 123;
        }

        /// <summary>
        /// graduated Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.DateTime&gt;
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void graduatedTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode

            education.graduated = new System.Nullable<System.DateTime>();
        }

        /// <summary>
        /// school Name Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void schoolNameTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode

            education.schoolName = "test";
        }

        /// <summary>
        /// state Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void stateTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode

            education.state = 35;
        }

        /// <summary>
        /// street Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void streetTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode

            education.street = "test";
        }

        /// <summary>
        /// street 2 Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void street2Test()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode

            education.street2 = "test";
        }

        /// <summary>
        /// years Attended Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void yearsAttendedTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode

            education.yearsAttended = "test";
        }

        /// <summary>
        /// zip Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;decimal&gt;
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void zipTest()
        {
            Education education = new Education(); //Trial Mode
            //Education education = new Education("place user name here", "place license key here"); //License Mode

           // education.zip = new System.Nullable<decimal>();
            education.zip = "97231";
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
