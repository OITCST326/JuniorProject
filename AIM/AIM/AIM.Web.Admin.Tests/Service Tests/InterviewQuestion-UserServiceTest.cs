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
// Module:       InterviewQuestion-UserServiceTest.cs
// Description:  Tests for the Interview Question class in the Unknown Assembly Name assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:55 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace TrackableEntities.ModelsTest
{

    /// <summary>
    /// Tests for the Interview Question Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Interview Question")]
    public class InterviewQuestionTest
    {
        #region Class Variables
        private InterviewQuestion _interviewQuestion;
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
            InterviewQuestion interviewQuestion = new InterviewQuestion(); //Trial Mode
            //InterviewQuestion interviewQuestion = new InterviewQuestion("place user name here", "place license key here"); //License Mode

            interviewQuestion.ExtensionData = new System.Runtime.Serialization.ExtensionDataObject();
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
            InterviewQuestion interviewQuestion = new InterviewQuestion(); //Trial Mode
            //InterviewQuestion interviewQuestion = new InterviewQuestion("place user name here", "place license key here"); //License Mode

            interviewQuestion.ModifiedProperties = new string[20];
        }

        /// <summary>
        /// Question Interview Question Mappings Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.QuestionInterviewQuestionMapping[]
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void QuestionInterviewQuestionMappingsTest()
        {
            InterviewQuestion interviewQuestion = new InterviewQuestion(); //Trial Mode
            //InterviewQuestion interviewQuestion = new InterviewQuestion("place user name here", "place license key here"); //License Mode

            interviewQuestion.QuestionInterviewQuestionMappings = new TrackableEntities.Models.QuestionInterviewQuestionMapping[0];
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
            InterviewQuestion interviewQuestion = new InterviewQuestion(); //Trial Mode
            //InterviewQuestion interviewQuestion = new InterviewQuestion("place user name here", "place license key here"); //License Mode

            interviewQuestion.TrackingState = new TrackableEntities.TrackingState();
        }

        /// <summary>
        /// interview Questions Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void interviewQuestionsIDTest()
        {
            InterviewQuestion interviewQuestion = new InterviewQuestion(); //Trial Mode
            //InterviewQuestion interviewQuestion = new InterviewQuestion("place user name here", "place license key here"); //License Mode

            interviewQuestion.interviewQuestionsID = 123;
        }

        /// <summary>
        /// permissions Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void permissionsTest()
        {
            InterviewQuestion interviewQuestion = new InterviewQuestion(); //Trial Mode
            //InterviewQuestion interviewQuestion = new InterviewQuestion("place user name here", "place license key here"); //License Mode

            interviewQuestion.permissions = 123;
        }

        /// <summary>
        /// question Identification Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void questionIDTest()
        {
            InterviewQuestion interviewQuestion = new InterviewQuestion(); //Trial Mode
            //InterviewQuestion interviewQuestion = new InterviewQuestion("place user name here", "place license key here"); //License Mode

            interviewQuestion.questionID = new System.Nullable<int>();
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
