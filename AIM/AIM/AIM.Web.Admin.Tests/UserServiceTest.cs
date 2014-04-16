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
// Module:       UserServiceTest.cs
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
    public class UserServiceTest
    {
        #region Class Variables
        private UserService _userService;
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
            UserService userService = new UserService(); //Trial Mode
            //UserService userService = new UserService("place user name here", "place license key here"); //License Mode

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
            UserService userService = new UserService(); //Trial Mode
            //UserService userService = new UserService("place user name here", "place license key here"); //License Mode

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
            UserService userService = new UserService(); //Trial Mode
            //UserService userService = new UserService("place user name here", "place license key here"); //License Mode

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
            UserService userService = new UserService(); //Trial Mode
            //UserService userService = new UserService("place user name here", "place license key here"); //License Mode

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
            UserService userService = new UserService(); //Trial Mode
            //UserService userService = new UserService("place user name here", "place license key here"); //License Mode

            Task<bool> results;

            //Parameters
            int id = 123;

            results = userService.DeleteUser(id);
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
            UserService userService = new UserService(); //Trial Mode
            //UserService userService = new UserService("place user name here", "place license key here"); //License Mode


            //Parameters

            userService.Dispose();
        }

        #endregion // End of GeneratedMethods

        #endregion

    }
}
