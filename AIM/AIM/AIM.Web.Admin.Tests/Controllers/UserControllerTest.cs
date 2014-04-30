#region Includes
using System;
using System.Collections.Generic;
using System.Text;
//using NUnit.Framework;
using AIM.Web.Admin.Controllers;
//using System.Data.Entity;
//using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Web.Mvc;
//using AIM.Service.Entities.Models;
using AIM.Web.Admin.UserServiceReference;
//using TrackableEntities.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Web
// Module:       UserControllerTest.cs
// Description:  Tests for the User Controller class in the AIM. Web. Admin assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:54 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace AIM.Web.Admin.ControllersTest
{

    /// <summary>
    /// Tests for the User Controller Class
    /// Documentation: 
    /// </summary>
    [TestClass]//, Description("Tests for User Controller")]
    public class UserControllerTest
    {
        #region Class Variables
        private UserController _userController;
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
            UserController userController = new UserController(); //Trial Mode
            //UserController userController = new UserController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters

            results = userController.Index();
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
            UserController userController = new UserController(); //Trial Mode
            //UserController userController = new UserController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            int? id = 123;

            results = userController.Details(id);
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
            UserController userController = new UserController(); //Trial Mode
            //UserController userController = new UserController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters

            results = userController.Create();
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
            UserController userController = new UserController(); //Trial Mode
            //UserController userController = new UserController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            int? id = 123;

            //results = userController.Edit(id);
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
            UserController userController = new UserController(); //Trial Mode
            //UserController userController = new UserController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            int? id = 123;

            results = userController.Delete(id);
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
            UserController userController = new UserController(); //Trial Mode
            //UserController userController = new UserController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            int id = 123;

            results = userController.DeleteConfirmed(id);
        }

        #endregion // End of GeneratedMethods

        #endregion

    }
}
