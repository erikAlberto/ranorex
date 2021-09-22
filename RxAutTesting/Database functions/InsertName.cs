﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace RxDatabase.Database_functions
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InsertName recording.
    /// </summary>
    [TestModule("5dbc6118-c253-45cd-9662-b2b1649e6373", ModuleType.Recording, 1)]
    public partial class InsertName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RxDatabase.RxDatabaseRepository repository.
        /// </summary>
        public static global::RxDatabase.RxDatabaseRepository repo = global::RxDatabase.RxDatabaseRepository.Instance;

        static InsertName instance = new InsertName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertName()
        {
            txtFirstName = "John";
            txtLastName = "Public";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertName Instance
        {
            get { return instance; }
        }

#region Variables

        string _txtFirstName;

        /// <summary>
        /// Gets or sets the value of variable txtFirstName.
        /// </summary>
        [TestVariable("2f21c543-bc7b-4acf-98ba-f8b948c4922c")]
        public string txtFirstName
        {
            get { return _txtFirstName; }
            set { _txtFirstName = value; }
        }

        string _txtLastName;

        /// <summary>
        /// Gets or sets the value of variable txtLastName.
        /// </summary>
        [TestVariable("7a808b8f-6623-4956-8f57-9fa25592724a")]
        public string txtLastName
        {
            get { return _txtLastName; }
            set { _txtLastName = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DemoApplication.DatabaseTab.FirstName' at 14;7.", repo.DemoApplication.DatabaseTab.FirstNameInfo, new RecordItemIndex(0));
            repo.DemoApplication.DatabaseTab.FirstName.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$txtFirstName' with focus on 'DemoApplication.DatabaseTab.FirstName'.", repo.DemoApplication.DatabaseTab.FirstNameInfo, new RecordItemIndex(1));
            repo.DemoApplication.DatabaseTab.FirstName.PressKeys(txtFirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DemoApplication.DatabaseTab.LastName' at 9;5.", repo.DemoApplication.DatabaseTab.LastNameInfo, new RecordItemIndex(2));
            repo.DemoApplication.DatabaseTab.LastName.Click("9;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$txtLastName' with focus on 'DemoApplication.DatabaseTab.LastName'.", repo.DemoApplication.DatabaseTab.LastNameInfo, new RecordItemIndex(3));
            repo.DemoApplication.DatabaseTab.LastName.PressKeys(txtLastName);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
