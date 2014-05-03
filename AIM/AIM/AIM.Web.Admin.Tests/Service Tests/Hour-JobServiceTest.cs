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
// Module:       Hour-JobServiceTest.cs
// Description:  Tests for the Hour class in the Unknown Assembly Name assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:55 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace TrackableEntities.ModelsTest
{

    /// <summary>
    /// Tests for the Hour Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Hour")]
    public class HourTest
    {
        #region Class Variables
        private Hour _hour;
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
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.ExtensionData = new System.Runtime.Serialization.ExtensionDataObject();
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
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.Applicant = new TrackableEntities.Models.Applicant();
        }

        /// <summary>
        /// Jobs Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Job[]
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void JobsTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.Jobs = new TrackableEntities.Models.Job[0];
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
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.ModifiedProperties = new string[20];
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
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.TrackingState = new TrackableEntities.TrackingState();
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
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.applicantID = new System.Nullable<int>();
        }

        /// <summary>
        /// fri Close Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void friCloseTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.friClose = new System.Nullable<System.TimeSpan>();
        }

        /// <summary>
        /// fri Open Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void friOpenTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.friOpen = new System.Nullable<System.TimeSpan>();
        }

        /// <summary>
        /// hours Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void hoursIDTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.hoursID = 123;
        }

        /// <summary>
        /// mon Close Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void monCloseTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.monClose = new System.Nullable<System.TimeSpan>();
        }

        /// <summary>
        /// mon Open Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void monOpenTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.monOpen = new System.Nullable<System.TimeSpan>();
        }

        /// <summary>
        /// sat Close Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void satCloseTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.satClose = new System.Nullable<System.TimeSpan>();
        }

        /// <summary>
        /// sat Open Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void satOpenTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.satOpen = new System.Nullable<System.TimeSpan>();
        }

        /// <summary>
        /// sun Close Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void sunCloseTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.sunClose = new System.Nullable<System.TimeSpan>();
        }

        /// <summary>
        /// sun Open Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void sunOpenTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.sunOpen = new System.Nullable<System.TimeSpan>();
        }

        /// <summary>
        /// thurs Close Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void thursCloseTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.thursClose = new System.Nullable<System.TimeSpan>();
        }

        /// <summary>
        /// thurs Open Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void thursOpenTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.thursOpen = new System.Nullable<System.TimeSpan>();
        }

        /// <summary>
        /// tue Close Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void tueCloseTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.tueClose = new System.Nullable<System.TimeSpan>();
        }

        /// <summary>
        /// tue Open Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void tueOpenTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.tueOpen = new System.Nullable<System.TimeSpan>();
        }

        /// <summary>
        /// wed Close Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void wedCloseTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.wedClose = new System.Nullable<System.TimeSpan>();
        }

        /// <summary>
        /// wed Open Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;System.TimeSpan&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void wedOpenTest()
        {
            Hour hour = new Hour(); //Trial Mode
            //Hour hour = new Hour("place user name here", "place license key here"); //License Mode

            hour.wedOpen = new System.Nullable<System.TimeSpan>();
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
