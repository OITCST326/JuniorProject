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
// Module:       IUserServiceTest.cs
// Description:  Tests for the User Service class in the AIM. Service. Core assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:52 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace AIM.Service.AdministrativeTest
{

    /// <summary>
    /// Tests for the User Service Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for User Service")]
    public class IUserServiceTest
    {
        #region Class Variables
        private IUserService _userService;
        #endregion

        #region Property Tests

        #region GeneratedProperties

        // No public properties were found. No tests are generated for non-public scoped properties.

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        #region GeneratedMethods

        /// <summary>
        /// Get Users List Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;IEnumerable&lt;User&gt;&gt; GetUsersList()
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetUsersListTest()
        {
            IUserService userService = new IUserService(); //Trial Mode
            //IUserService userService = new IUserService("place user name here", "place license key here"); //License Mode

            Task<IEnumerable<User>> results;

            //Parameters

            results = userService.GetUsersList();
        }

        /// <summary>
        /// Get User Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;User&gt; GetUser(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetUserTest()
        {
            IUserService userService = new IUserService(); //Trial Mode
            //IUserService userService = new IUserService("place user name here", "place license key here"); //License Mode

            Task<User> results;

            //Parameters
            int id = 123;

            results = userService.GetUser(id);
        }

        /// <summary>
        /// Update User Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;User&gt; UpdateUser(User entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void UpdateUserTest()
        {
            IUserService userService = new IUserService(); //Trial Mode
            //IUserService userService = new IUserService("place user name here", "place license key here"); //License Mode

            Task<User> results;

            //Parameters
            User entity = new User();

            results = userService.UpdateUser(entity);
        }

        /// <summary>
        /// Create User Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;User&gt; CreateUser(User entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void CreateUserTest()
        {
            IUserService userService = new IUserService(); //Trial Mode
            //IUserService userService = new IUserService("place user name here", "place license key here"); //License Mode

            Task<User> results;

            //Parameters
            User entity = new User();

            results = userService.CreateUser(entity);
        }

        /// <summary>
        /// Delete User Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;bool&gt; DeleteUser(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void DeleteUserTest()
        {
            IUserService userService = new IUserService(); //Trial Mode
            //IUserService userService = new IUserService("place user name here", "place license key here"); //License Mode

            Task<bool> results;

            //Parameters
            int id = 123;

            results = userService.DeleteUser(id);
        }

        /// <summary>
        /// Get Users List Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;IEnumerable&lt;User&gt;&gt; GetUsersListAsync()
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetUsersListAsyncTest()
        {
            IUserService userService = new IUserService(); //Trial Mode
            //IUserService userService = new IUserService("place user name here", "place license key here"); //License Mode

            Task<IEnumerable<User>> results;

            //Parameters

            results = userService.GetUsersListAsync();
        }

        /// <summary>
        /// Get User Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;User&gt; GetUserAsync(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void GetUserAsyncTest()
        {
            IUserService userService = new IUserService(); //Trial Mode
            //IUserService userService = new IUserService("place user name here", "place license key here"); //License Mode

            Task<User> results;

            //Parameters
            int id = 123;

            results = userService.GetUserAsync(id);
        }

        /// <summary>
        /// Update User Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;User&gt; UpdateUserAsync(User entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void UpdateUserAsyncTest()
        {
            IUserService userService = new IUserService(); //Trial Mode
            //IUserService userService = new IUserService("place user name here", "place license key here"); //License Mode

            Task<User> results;

            //Parameters
            User entity = new User();

            results = userService.UpdateUserAsync(entity);
        }

        /// <summary>
        /// Create User Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;User&gt; CreateUserAsync(User entity)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void CreateUserAsyncTest()
        {
            IUserService userService = new IUserService(); //Trial Mode
            //IUserService userService = new IUserService("place user name here", "place license key here"); //License Mode

            Task<User> results;

            //Parameters
            User entity = new User();

            results = userService.CreateUserAsync(entity);
        }

        /// <summary>
        /// Delete User Async Method Test
        /// Documentation   :  
        /// Method Signature:  Task&lt;bool&gt; DeleteUserAsync(int id)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void DeleteUserAsyncTest()
        {
            IUserService userService = new IUserService(); //Trial Mode
            //IUserService userService = new IUserService("place user name here", "place license key here"); //License Mode

            Task<bool> results;

            //Parameters
            int id = 123;

            results = userService.DeleteUserAsync(id);
        }

        #endregion // End of GeneratedMethods

        #endregion

    }
}
