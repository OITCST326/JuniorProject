#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
//using NUnit
using AIM.Web.Admin.Controllers;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.Owin.Security;
using AIM.Web.Admin.Models;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Web
// Module:       AccountControllerTest.cs
// Description:  Tests for the Account Controller class in the AIM. Web. Admin assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:54 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace AIM.Web.Admin.ControllersTest
{

    /// <summary>
    /// Tests for the Account Controller Class
    /// Documentation: 
    /// </summary>
    [TestClass, Description("Tests for Account Controller")]
    public class AccountControllerTest
    {
        #region Class Variables
        private AccountController _accountController;
        #endregion

        #region Property Tests

        #region GeneratedProperties

        /// <summary>
        /// User Manager Property Test
        /// Documentation:  
        /// Property Type:  UserManager&lt;ApplicationUser&gt;
        /// Access       :  Read Only
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void UserManagerTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            accountController.UserManager = new UserManager<ApplicationUser>();
        }

        /// <summary>
        /// Login Provider Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void LoginProviderTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            accountController.LoginProvider = "test";
        }

        /// <summary>
        /// Redirect Uri Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void RedirectUriTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            accountController.RedirectUri = "test";
        }

        /// <summary>
        /// User Id Property Test
        /// Documentation:  
        /// Property Type:  string
        /// Access       :  Read/Write
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void UserIdTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            accountController.UserId = "test";
        }

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        #region GeneratedMethods

        /// <summary>
        /// Login Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult Login(string returnUrl)
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void LoginTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            string returnUrl = "test";

            results = accountController.Login(returnUrl);
        }

        /// <summary>
        /// Login Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;ActionResult&gt; Login(LoginViewModel model, string returnUrl)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void Login1Test()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            Task<ActionResult> results;

            //Parameters
            LoginViewModel model = new LoginViewModel();
            string returnUrl = "test";

            results = accountController.Login(model, returnUrl);
        }

        /// <summary>
        /// Register Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult Register()
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void RegisterTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters

            results = accountController.Register();
        }

        /// <summary>
        /// Register Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;ActionResult&gt; Register(RegisterViewModel model)
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void Register1Test()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            Task<ActionResult> results;

            //Parameters
            RegisterViewModel model = new RegisterViewModel();

            results = accountController.Register(model);
        }

        /// <summary>
        /// Disassociate Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;ActionResult&gt; Disassociate(string loginProvider, string providerKey)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void DisassociateTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            Task<ActionResult> results;

            //Parameters
            string loginProvider = "test";
            string providerKey = "test";

            results = accountController.Disassociate(loginProvider, providerKey);
        }

        /// <summary>
        /// Manage Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult Manage(ManageMessageId? message)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void ManageTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            ManageMessageId? message = new ManageMessageId?();

            results = accountController.Manage(message);
        }

        /// <summary>
        /// Manage Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;ActionResult&gt; Manage(ManageUserViewModel model)
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void Manage1Test()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            Task<ActionResult> results;

            //Parameters
            ManageUserViewModel model = new ManageUserViewModel();

            results = accountController.Manage(model);
        }

        /// <summary>
        /// External Login Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult ExternalLogin(string provider, string returnUrl)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void ExternalLoginTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            string provider = "test";
            string returnUrl = "test";

            results = accountController.ExternalLogin(provider, returnUrl);
        }

        /// <summary>
        /// External Login Callback Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;ActionResult&gt; ExternalLoginCallback(string returnUrl)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void ExternalLoginCallbackTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            Task<ActionResult> results;

            //Parameters
            string returnUrl = "test";

            results = accountController.ExternalLoginCallback(returnUrl);
        }

        /// <summary>
        /// Link Login Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult LinkLogin(string provider)
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void LinkLoginTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters
            string provider = "test";

            results = accountController.LinkLogin(provider);
        }

        /// <summary>
        /// Link Login Callback Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;ActionResult&gt; LinkLoginCallback()
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void LinkLoginCallbackTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            Task<ActionResult> results;

            //Parameters

            results = accountController.LinkLoginCallback();
        }

        /// <summary>
        /// External Login Confirmation Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;ActionResult&gt; ExternalLoginConfirmation(ExternalLoginConfirmationViewModel model, string returnUrl)
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void ExternalLoginConfirmationTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            Task<ActionResult> results;

            //Parameters
            ExternalLoginConfirmationViewModel model = new ExternalLoginConfirmationViewModel();
            string returnUrl = "test";

            results = accountController.ExternalLoginConfirmation(model, returnUrl);
        }

        /// <summary>
        /// Log Off Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult LogOff()
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void LogOffTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters

            results = accountController.LogOff();
        }

        /// <summary>
        /// External Login Failure Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult ExternalLoginFailure()
        /// </summary>
        [TestMethod]
       // [Ignore("Please Implement")]
        public void ExternalLoginFailureTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters

            results = accountController.ExternalLoginFailure();
        }

        /// <summary>
        /// Remove Account List Method Test
        /// Documentation   :  
        /// Method Signature:  ActionResult RemoveAccountList()
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void RemoveAccountListTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode

            ActionResult results;

            //Parameters

            results = accountController.RemoveAccountList();
        }

        /// <summary>
        /// Execute Result Method Test
        /// Documentation   :  
        /// Method Signature:  void ExecuteResult(ControllerContext context)
        /// </summary>
        [TestMethod]
        //[Ignore("Please Implement")]
        public void ExecuteResultTest()
        {
            AccountController accountController = new AccountController(); //Trial Mode
            //AccountController accountController = new AccountController("place user name here", "place license key here"); //License Mode


            //Parameters
            ControllerContext context = new ControllerContext();

            accountController.ExecuteResult(context);
        }

        #endregion // End of GeneratedMethods

        #endregion

    }
}
