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
// Module:       QuestionQuestionnaire-JobServiceTest.cs
// Description:  Tests for the Question Questionnaire class in the Unknown Assembly Name assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:55 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace TrackableEntities.ModelsTest
{

    /// <summary>
    /// Tests for the Question Questionnaire Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Question Questionnaire")]
    public class QuestionQuestionnaireTest
    {
        #region Class Variables
        private QuestionQuestionnaire _questionQuestionnaire;
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
            QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire(); //Trial Mode
            //QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire("place user name here", "place license key here"); //License Mode

            questionQuestionnaire.ExtensionData = new System.Runtime.Serialization.ExtensionDataObject();
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
            QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire(); //Trial Mode
            //QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire("place user name here", "place license key here"); //License Mode

            questionQuestionnaire.ModifiedProperties = new string[20];
        }

        /// <summary>
        /// Question Property Test
        /// Documentation:  
        /// Property Type:  TrackableEntities.Models.Question
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void QuestionTest()
        {
            QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire(); //Trial Mode
            //QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire("place user name here", "place license key here"); //License Mode

            questionQuestionnaire.Question = new TrackableEntities.Models.Question();
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
            QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire(); //Trial Mode
            //QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire("place user name here", "place license key here"); //License Mode

            questionQuestionnaire.Questionnaire = new TrackableEntities.Models.Questionnaire();
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
            QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire(); //Trial Mode
            //QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire("place user name here", "place license key here"); //License Mode

            questionQuestionnaire.TrackingState = new TrackableEntities.TrackingState();
        }

        /// <summary>
        /// number Of Questions Property Test
        /// Documentation:  
        /// Property Type:  System.Nullable&lt;int&gt;
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void numberOfQuestionsTest()
        {
            QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire(); //Trial Mode
            //QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire("place user name here", "place license key here"); //License Mode

            questionQuestionnaire.numberOfQuestions = new System.Nullable<int>();
        }

        /// <summary>
        /// question Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void questionIDTest()
        {
            QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire(); //Trial Mode
            //QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire("place user name here", "place license key here"); //License Mode

            questionQuestionnaire.questionID = 123;
        }

        /// <summary>
        /// questionnaire Identification Property Test
        /// Documentation:  
        /// Property Type:  int
        /// Access       :  Read/Write
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void questionnaireIDTest()
        {
            QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire(); //Trial Mode
            //QuestionQuestionnaire questionQuestionnaire = new QuestionQuestionnaire("place user name here", "place license key here"); //License Mode

            questionQuestionnaire.questionnaireID = 123;
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
