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
// Module:       IQuestionServiceTest.cs
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
    public class IQuestionServiceTest
    {
        #region Class Variables
        private IQuestionService _questionService;
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
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

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
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

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
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

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
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

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
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

            Task<bool> results;

            //Parameters
            int id = 123;

            results = questionService.DeleteQuestion(id);
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
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

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
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

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
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

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
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

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
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

            Task<bool> results;

            //Parameters
            int id = 123;

            results = questionService.DeleteQuestionnaire(id);
        }

        /// <summary>
        /// Get Questions List Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;IEnumerable&lt;Question&gt;&gt; GetQuestionsListAsync()
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetQuestionsListAsyncTest()
        {
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

            Task<IEnumerable<Question>> results;

            //Parameters

            results = questionService.GetQuestionsListAsync();
        }

        /// <summary>
        /// Get Question Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Question&gt; GetQuestionAsync(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetQuestionAsyncTest()
        {
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

            Task<Question> results;

            //Parameters
            int id = 123;

            results = questionService.GetQuestionAsync(id);
        }

        /// <summary>
        /// Update Question Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Question&gt; UpdateQuestionAsync(Question entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void UpdateQuestionAsyncTest()
        {
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

            Task<Question> results;

            //Parameters
            Question entity = new Question();

            results = questionService.UpdateQuestionAsync(entity);
        }

        /// <summary>
        /// Create Question Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Question&gt; CreateQuestionAsync(Question entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void CreateQuestionAsyncTest()
        {
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

            Task<Question> results;

            //Parameters
            Question entity = new Question();

            results = questionService.CreateQuestionAsync(entity);
        }

        /// <summary>
        /// Delete Question Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;bool&gt; DeleteQuestionAsync(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void DeleteQuestionAsyncTest()
        {
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

            Task<bool> results;

            //Parameters
            int id = 123;

            results = questionService.DeleteQuestionAsync(id);
        }

        /// <summary>
        /// Get Questionnaires List Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;IEnumerable&lt;Questionnaire&gt;&gt; GetQuestionnairesListAsync()
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetQuestionnairesListAsyncTest()
        {
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

            Task<IEnumerable<Questionnaire>> results;

            //Parameters

            results = questionService.GetQuestionnairesListAsync();
        }

        /// <summary>
        /// Get Questionnaire Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Questionnaire&gt; GetQuestionnaireAsync(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetQuestionnaireAsyncTest()
        {
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

            Task<Questionnaire> results;

            //Parameters
            int id = 123;

            results = questionService.GetQuestionnaireAsync(id);
        }

        /// <summary>
        /// Update Questionnaire Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Questionnaire&gt; UpdateQuestionnaireAsync(Questionnaire entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void UpdateQuestionnaireAsyncTest()
        {
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

            Task<Questionnaire> results;

            //Parameters
            Questionnaire entity = new Questionnaire();

            results = questionService.UpdateQuestionnaireAsync(entity);
        }

        /// <summary>
        /// Create Questionnaire Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;Questionnaire&gt; CreateQuestionnaireAsync(Questionnaire entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void CreateQuestionnaireAsyncTest()
        {
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

            Task<Questionnaire> results;

            //Parameters
            Questionnaire entity = new Questionnaire();

            results = questionService.CreateQuestionnaireAsync(entity);
        }

        /// <summary>
        /// Delete Questionnaire Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;bool&gt; DeleteQuestionnaireAsync(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void DeleteQuestionnaireAsyncTest()
        {
            IQuestionService questionService = new IQuestionService(); //Trial Mode
            //IQuestionService questionService = new IQuestionService("place user name here", "place license key here"); //License Mode

            Task<bool> results;

            //Parameters
            int id = 123;

            results = questionService.DeleteQuestionnaireAsync(id);
        }

        #endregion // End of GeneratedMethods

        #endregion

    }
}
