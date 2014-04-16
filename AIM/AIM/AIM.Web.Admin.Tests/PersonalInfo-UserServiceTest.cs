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
// Module:       PersonalInfo-UserServiceTest.cs
// Description:  Tests for the Personal Info class in the Unknown Assembly Name assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:55 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace TrackableEntities.ModelsTest
{

    /// <summary>
    /// Tests for the Personal Info Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Personal Info")]
    public class PersonalInfoTest
    {
        #region Class Variables
        private PersonalInfo _personalInfo;
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
            PersonalInfo personalInfo = new PersonalInfo(); //Trial Mode
            //PersonalInfo personalInfo = new PersonalInfo("place user name here", "place license key here"); //License Mode

            personalInfo.ExtensionData = new System.Runtime.Serialization.ExtensionDataObject();
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
            PersonalInfo personalInfo = new PersonalInfo(); //Trial Mode
            //PersonalInfo personalInfo = new PersonalInfo("place user name here", "place license key here"); //License Mode

            personalInfo.ModifiedProperties = new string[20];
        }

        /// <summary>
        /// Personal Info Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void PersonalInfoIDTest()
        {
            PersonalInfo personalInfo = new PersonalInfo(); //Trial Mode
            //PersonalInfo personalInfo = new PersonalInfo("place user name here", "place license key here"); //License Mode

            personalInfo.PersonalInfoID = 123;
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
            PersonalInfo personalInfo = new PersonalInfo(); //Trial Mode
            //PersonalInfo personalInfo = new PersonalInfo("place user name here", "place license key here"); //License Mode

            personalInfo.TrackingState = new TrackableEntities.TrackingState();
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
            PersonalInfo personalInfo = new PersonalInfo(); //Trial Mode
            //PersonalInfo personalInfo = new PersonalInfo("place user name here", "place license key here"); //License Mode

            personalInfo.Users = new TrackableEntities.Models.User[0];
        }

        /// <summary>
        /// alias Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void aliasTest()
        {
            PersonalInfo personalInfo = new PersonalInfo(); //Trial Mode
            //PersonalInfo personalInfo = new PersonalInfo("place user name here", "place license key here"); //License Mode

            personalInfo.alias = "test";
        }

        /// <summary>
        /// city Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void cityTest()
        {
            PersonalInfo personalInfo = new PersonalInfo(); //Trial Mode
            //PersonalInfo personalInfo = new PersonalInfo("place user name here", "place license key here"); //License Mode

            personalInfo.city = "test";
        }

        /// <summary>
        /// phone Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;decimal&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void phoneTest()
        {
            PersonalInfo personalInfo = new PersonalInfo(); //Trial Mode
            //PersonalInfo personalInfo = new PersonalInfo("place user name here", "place license key here"); //License Mode

            personalInfo.phone = new System.Nullable<decimal>();
        }

        /// <summary>
        /// street Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void streetTest()
        {
            PersonalInfo personalInfo = new PersonalInfo(); //Trial Mode
            //PersonalInfo personalInfo = new PersonalInfo("place user name here", "place license key here"); //License Mode

            personalInfo.street = "test";
        }

        /// <summary>
        /// street 2 Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void street2Test()
        {
            PersonalInfo personalInfo = new PersonalInfo(); //Trial Mode
            //PersonalInfo personalInfo = new PersonalInfo("place user name here", "place license key here"); //License Mode

            personalInfo.street2 = "test";
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
            PersonalInfo personalInfo = new PersonalInfo(); //Trial Mode
            //PersonalInfo personalInfo = new PersonalInfo("place user name here", "place license key here"); //License Mode

            personalInfo.userID = new System.Nullable<int>();
        }

        /// <summary>
        /// zip Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;decimal&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void zipTest()
        {
            PersonalInfo personalInfo = new PersonalInfo(); //Trial Mode
            //PersonalInfo personalInfo = new PersonalInfo("place user name here", "place license key here"); //License Mode

            personalInfo.zip = new System.Nullable<decimal>();
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
