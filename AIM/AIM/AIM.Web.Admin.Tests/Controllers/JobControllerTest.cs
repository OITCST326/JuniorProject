#region Includes
using System;
using System.Collections.Generic;
using System.Text;
//using NUnit.Framework;
using AIM.Web.Admin.Controllers;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AIM.Client.Entities.Models;
//using AIM.Service.Entities.Models;
using AIM.Web.Admin.JobServiceReference;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Web
// Module:       JobControllerTest.cs
// Description:  Tests for the Job Controller class in the AIM. Web. Admin assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:54 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace AIM.Web.Admin.ControllersTest
{

    /// <summary>
    /// Tests for the Job Controller Class
    /// Documentation: 
    /// </summary>
    [TestClass]//, Description("Tests for Job Controller")]
    public partial class JobControllerTest 
    {
        #region Class Variables
        private JobController _jobController;
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
       // [Ignore("Please Implement")]
        public void IndexTest()
        {
            JobController jobController = new JobController(); //Trial Mode
            //JobController jobController = new JobController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters

            results = jobController.Index();
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
            JobController jobController = new JobController(); //Trial Mode
            //JobController jobController = new JobController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            int? id = 123;

            results = jobController.Details(id);
        }

        /// <summary>
        /// Create Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult Create()
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void CreateTest()
        {
            JobController jobController = new JobController(); //Trial Mode
            //JobController jobController = new JobController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters

            results = jobController.Create();
        }

        /// <summary>
        /// Edit Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult Edit(int? id)
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void EditTest()
        {
            JobController jobController = new JobController(); //Trial Mode
            //JobController jobController = new JobController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            int? id = 123;

            //results = jobController.Edit(id);
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
            JobController jobController = new JobController(); //Trial Mode
            //JobController jobController = new JobController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            int? id = 123;

            results = jobController.Delete(id);
        }

        /// <summary>
        /// Delete Confirmed Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult DeleteConfirmed(int id)
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void DeleteConfirmedTest()
        {
            JobController jobController = new JobController(); //Trial Mode
            //JobController jobController = new JobController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            int id = 123;

            results = jobController.DeleteConfirmed(id);
        }

        #endregion // End of GeneratedMethods

        #endregion

    }
}
