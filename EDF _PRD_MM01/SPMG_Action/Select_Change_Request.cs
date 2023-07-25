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

namespace EDF__PRD_MM01.SPMG_Action
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Select_Change_Request recording.
    /// </summary>
    [TestModule("df8050ee-1f92-4fee-9131-266fff89ac6e", ModuleType.Recording, 1)]
    public partial class Select_Change_Request : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repository.
        /// </summary>
        public static global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repo = global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository.Instance;

        static Select_Change_Request instance = new Select_Change_Request();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_Change_Request()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_Change_Request Instance
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
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(0));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Menu.mn_MyTasks' at Center.", repo.SimpleMDG.Menu.mn_MyTasksInfo, new RecordItemIndex(1));
            repo.SimpleMDG.Menu.mn_MyTasks.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Menu.mn_ChangeRequests' at Center.", repo.SimpleMDG.Menu.mn_ChangeRequestsInfo, new RecordItemIndex(2));
            repo.SimpleMDG.Menu.mn_ChangeRequests.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
