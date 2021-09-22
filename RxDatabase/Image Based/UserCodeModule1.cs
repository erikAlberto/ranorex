/*
 * Created by Ranorex
 * User: Alber
 * Date: 9/13/2021
 * Time: 9:39 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace RxDatabase.Image_Based
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("89FED184-3677-477C-9B90-ABC3F31AA411", ModuleType.UserCode, 1)]
    public class UserCodeModule1 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule1()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            // Start here          
            
            var repo = RxDatabaseRepository.Instance;
            var lastName = repo.DemoApplication.DatabaseTab.LastName;
            var firstName = repo.DemoApplication.DatabaseTab.FirstName;
            var database = repo.DemoApplication.Database;

            database.Click();
            
            firstName.TextValue = "TESTINGGGG";
            

        }
    }
}
