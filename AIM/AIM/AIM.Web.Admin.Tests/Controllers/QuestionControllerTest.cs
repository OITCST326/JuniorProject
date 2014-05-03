#region Includes
using System;
using System.Collections.Generic;
using System.Text;
//using NUnit.Framework;
using AIM.Web.Admin.Controllers;
using System.Linq;
using System.Net;
using System.Web.Mvc;
//using AIM.Service.Entities.Models;
using AIM.Client.Entities.Models;
using AIM.Web.Admin.QuestionServiceReference;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Web
// Module:       QuestionControllerTest.cs
// Description:  Tests for the Question Controller class in the AIM. Web. Admin assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:54 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace AIM.Web.Admin.ControllersTest
{

    /// <summary>
    /// Tests for the Question Controller Class
    /// Documentation: 
    /// </summary>
    [TestClass]//, Description("Tests for Question Controller")]
    public class QuestionControllerTest
    {
        #region Class Variables
        private QuestionController _questionController;
        #endregion

        #region Property Tests

        #region GeneratedProperties

        // No public properties were found. No tests are generated for non-public scoped properties.

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        #region GeneratedMethods

        /// <summary>
        /// Index Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult Index()
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void IndexTest()
        {
            QuestionController questionController = new QuestionController(); //Trial Mode
            //QuestionController questionController = new QuestionController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters

            results = questionController.Index();
        }

        /// <summary>
        /// Details Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult Details(int? id)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void DetailsTest()
        {
            QuestionController questionController = new QuestionController(); //Trial Mode
            //QuestionController questionController = new QuestionController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            int? id = 123;

            results = questionController.Details(id);
        }

        /// <summary>
        /// Create Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult Create()
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void CreateTest()
        {
            QuestionController questionController = new QuestionController(); //Trial Mode
            //QuestionController questionController = new QuestionController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters

            results = questionController.Create();
        }

        /// <summary>
        /// Edit Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult Edit(int? id)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void EditTest()
        {
            QuestionController questionController = new QuestionController(); //Trial Mode
            //QuestionController questionController = new QuestionController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            int? id = 123;

            //results = questionController.Edit(id);
        }

        /// <summary>
        /// Delete Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult Delete(int? id)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void DeleteTest()
        {
            QuestionController questionController = new QuestionController(); //Trial Mode
            //QuestionController questionController = new QuestionController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            int? id = 123;

            results = questionController.Delete(id);
        }

        /// <summary>
        /// Delete Confirmed Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult DeleteConfirmed(int id)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void DeleteConfirmedTest()
        {
            QuestionController questionController = new QuestionController(); //Trial Mode
            //QuestionController questionController = new QuestionController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            int id = 123;

            results = questionController.DeleteConfirmed(id);
        }

        #endregion // End of GeneratedMethods

        #endregion

    }
}
