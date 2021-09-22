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

namespace RxDatabase.Image_Based
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AdvancedImage recording.
    /// </summary>
    [TestModule("0de5f23d-e931-441d-82f0-796e1bf1078d", ModuleType.Recording, 1)]
    public partial class AdvancedImage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RxDatabase.RxDatabaseRepository repository.
        /// </summary>
        public static global::RxDatabase.RxDatabaseRepository repo = global::RxDatabase.RxDatabaseRepository.Instance;

        static AdvancedImage instance = new AdvancedImage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AdvancedImage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AdvancedImage Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DemoApplication.MonthCalendar1' at 170;88.", repo.DemoApplication.MonthCalendar1Info, new RecordItemIndex(0));
            repo.DemoApplication.MonthCalendar1.Click("170;88");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DemoApplication.MonthCalendar1' at 135;98.", repo.DemoApplication.MonthCalendar1Info, new RecordItemIndex(1));
            repo.DemoApplication.MonthCalendar1.Click("135;98");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
