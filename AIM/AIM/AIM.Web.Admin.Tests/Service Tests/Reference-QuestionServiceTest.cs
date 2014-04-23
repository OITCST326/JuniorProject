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
// Module:       Reference-QuestionServiceTest.cs
// Description:  Tests for the Reference class in the Unknown Assembly Name assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:55 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace TrackableEntities.ModelsTest
{

    /// <summary>
    /// Tests for the Reference Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Reference")]
    public class ReferenceTest
    {
        #region Class Variables
        private Reference _reference;
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
            Reference reference = new Reference(); //Trial Mode
            //Reference reference = new Reference("place user name here", "place license key here"); //License Mode

            reference.ExtensionData = new System.Runtime.Serialization.ExtensionDataObject();
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
            Reference reference = new Reference(); //Trial Mode
            //Reference reference = new Reference("place user name here", "place license key here"); //License Mode

            reference.Applicant = new TrackableEntities.Models.Applicant();
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
            Reference reference = new Reference(); //Trial Mode
            //Reference reference = new Reference("place user name here", "place license key here"); //License Mode

            reference.ModifiedProperties = new string[20];
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
            Reference reference = new Reference(); //Trial Mode
            //Reference reference = new Reference("place user name here", "place license key here"); //License Mode

            reference.TrackingState = new TrackableEntities.TrackingState();
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
            Reference reference = new Reference(); //Trial Mode
            //Reference reference = new Reference("place user name here", "place license key here"); //License Mode

            reference.applicantID = new System.Nullable<int>();
        }

        /// <summary>
        /// ref Company Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void refCompanyTest()
        {
            Reference reference = new Reference(); //Trial Mode
            //Reference reference = new Reference("place user name here", "place license key here"); //License Mode

            reference.refCompany = "test";
        }

        /// <summary>
        /// ref Full Name Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void refFullNameTest()
        {
            Reference reference = new Reference(); //Trial Mode
            //Reference reference = new Reference("place user name here", "place license key here"); //License Mode

            reference.refFullName = "test";
        }

        /// <summary>
        /// ref Phone Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;decimal&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void refPhoneTest()
        {
            Reference reference = new Reference(); //Trial Mode
            //Reference reference = new Reference("place user name here", "place license key here"); //License Mode

            reference.refPhone = new System.Nullable<decimal>();
        }

        /// <summary>
        /// ref Title Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void refTitleTest()
        {
            Reference reference = new Reference(); //Trial Mode
            //Reference reference = new Reference("place user name here", "place license key here"); //License Mode

            reference.refTitle = "test";
        }

        /// <summary>
        /// reference Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void referenceIDTest()
        {
            Reference reference = new Reference(); //Trial Mode
            //Reference reference = new Reference("place user name here", "place license key here"); //License Mode

            reference.referenceID = 123;
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
