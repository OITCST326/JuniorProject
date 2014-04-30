#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AIM.Service.Administrative;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using AIM.Service.Entities.Models;
using TrackableEntities.Common;
using TrackableEntities.EF6;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Service
// Module:       QuestionServiceTest.cs
// Description:  Tests for the Question Service class in the AIM. Service. Core assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:52 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace AIM.Service.AdministrativeTest
{

    /// <summary>
    /// Tests for the Question Service Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Question Service")]
    public class QuestionServiceTest
    {
        #region Class Variables
        private QuestionService _questionService;
        #endregion

        #region Property Tests

        #region GeneratedProperties

        // No public properties were found. No tests are generated for non-public scoped properties.

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        #region GeneratedMethods

        /// <summary>
        /// Get Questions List Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;IEnumerable&lt;Question&gt;&gt; GetQuestionsList()
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetQuestionsListTest()
        {
            QuestionService questionService = new QuestionService(); //Trial Mode
            //QuestionService questionService = new QuestionService("place user name here", "place license key here"); //License Mode

            Task<IEnumerable<Question>> results;

            //Parameters

            results = questionService.GetQuestionsList();
        }

        /// <summary>
        /// Get Question Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Question&gt; GetQuestion(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetQuestionTest()
        {
            QuestionService questionService = new QuestionService(); //Trial Mode
            //QuestionService questionService = new QuestionService("place user name here", "place license key here"); //License Mode

            Task<Question> results;

            //Parameters
            int id = 123;

            results = questionService.GetQuestion(id);
        }

        /// <summary>
        /// Update Question Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Question&gt; UpdateQuestion(Question entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void UpdateQuestionTest()
        {
            QuestionService questionService = new QuestionService(); //Trial Mode
            //QuestionService questionService = new QuestionService("place user name here", "place license key here"); //License Mode

            Task<Question> results;

            //Parameters
            Question entity = new Question();

            results = questionService.UpdateQuestion(entity);
        }

        /// <summary>
        /// Create Question Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Question&gt; CreateQuestion(Question entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void CreateQuestionTest()
        {
            QuestionService questionService = new QuestionService(); //Trial Mode
            //QuestionService questionService = new QuestionService("place user name here", "place license key here"); //License Mode

            Task<Question> results;

            //Parameters
            Question entity = new Question();

            results = questionService.CreateQuestion(entity);
        }

        /// <summary>
        /// Delete Question Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;bool&gt; DeleteQuestion(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void DeleteQuestionTest()
        {
            QuestionService questionService = new QuestionService(); //Trial Mode
            //QuestionService questionService = new QuestionService("place user name here", "place license key here"); //License Mode

            Task<bool> results;

            //Parameters
            int id = 123;

            results = questionService.DeleteQuestion(id);
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
            QuestionService questionService = new QuestionService(); //Trial Mode
            //QuestionService questionService = new QuestionService("place user name here", "place license key here"); //License Mode


            //Parameters

            questionService.Dispose();
        }

        /// <summary>
        /// Get Questionnaires List Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;IEnumerable&lt;Questionnaire&gt;&gt; GetQuestionnairesList()
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetQuestionnairesListTest()
        {
            QuestionService questionService = new QuestionService(); //Trial Mode
            //QuestionService questionService = new QuestionService("place user name here", "place license key here"); //License Mode

            Task<IEnumerable<Questionnaire>> results;

            //Parameters

            results = questionService.GetQuestionnairesList();
        }

        /// <summary>
        /// Get Questionnaire Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Questionnaire&gt; GetQuestionnaire(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetQuestionnaireTest()
        {
            QuestionService questionService = new QuestionService(); //Trial Mode
            //QuestionService questionService = new QuestionService("place user name here", "place license key here"); //License Mode

            Task<Questionnaire> results;

            //Parameters
            int id = 123;

            results = questionService.GetQuestionnaire(id);
        }

        /// <summary>
        /// Update Questionnaire Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Questionnaire&gt; UpdateQuestionnaire(Questionnaire entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void UpdateQuestionnaireTest()
        {
            QuestionService questionService = new QuestionService(); //Trial Mode
            //QuestionService questionService = new QuestionService("place user name here", "place license key here"); //License Mode

            Task<Questionnaire> results;

            //Parameters
            Questionnaire entity = new Questionnaire();

            results = questionService.UpdateQuestionnaire(entity);
        }

        /// <summary>
        /// Create Questionnaire Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Questionnaire&gt; CreateQuestionnaire(Questionnaire entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void CreateQuestionnaireTest()
        {
            QuestionService questionService = new QuestionService(); //Trial Mode
            //QuestionService questionService = new QuestionService("place user name here", "place license key here"); //License Mode

            Task<Questionnaire> results;

            //Parameters
            Questionnaire entity = new Questionnaire();

            results = questionService.CreateQuestionnaire(entity);
        }

        /// <summary>
        /// Delete Questionnaire Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;bool&gt; DeleteQuestionnaire(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void DeleteQuestionnaireTest()
        {
            QuestionService questionService = new QuestionService(); //Trial Mode
            //QuestionService questionService = new QuestionService("place user name here", "place license key here"); //License Mode

            Task<bool> results;

            //Parameters
            int id = 123;

            results = questionService.DeleteQuestionnaire(id);
        }

        #endregion // End of GeneratedMethods

        #endregion

    }
}
