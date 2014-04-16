#region Includes
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AIM.Web.Admin;
using Microsoft.Owin;
using Owin;
#endregion

///////////////////////////////////////////////////////////////////////////////
// Copyright 2014 (c) by Microsoft All Rights Reserved.
//  
// Project:      Web
// Module:       StartupTest.cs
// Description:  Tests for the Startup class in the AIM. Web. Admin assembly.
//  
// Date:       Author:           Comments:
// 4/14/2014 1:55 PM  John     Module created.
///////////////////////////////////////////////////////////////////////////////
namespace AIM.Web.AdminTest
{

    /// <summary>
    /// Tests for the Startup Class
    /// Documentation: 
    /// </summary>
    [TestFixture, Description("Tests for Startup")]
    public class StartupTest
    {
        #region Class Variables
        private Startup _startup;
        #endregion

        #region Property Tests

        #region GeneratedProperties

        // No public properties were found. No tests are generated for non-public scoped properties.

        #endregion // End of GeneratedProperties

        #endregion

        #region Method Tests

        #region GeneratedMethods

        /// <summary>
        /// Configuration Method Test
        /// Documentation   :  
        /// Method Signature:  void Configuration(IAppBuilder app)
        /// </summary>
        [Test]
        [Ignore("Please Implement")]
        public void ConfigurationTest()
        {
            Startup startup = new Startup(); //Trial Mode
            //Startup startup = new Startup("place user name here", "place license key here"); //License Mode


            //Parameters
            IAppBuilder app = null;

            startup.Configuration(app);
        }

        #endregion // End of GeneratedMethods

        #endregion

    }
}
