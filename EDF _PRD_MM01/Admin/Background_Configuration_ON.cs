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

namespace EDF__PRD_MM01.Admin
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Background_Configuration_ON recording.
    /// </summary>
    [TestModule("b2ea99f8-c5c5-4bef-a1c5-efdb339ab078", ModuleType.Recording, 1)]
    public partial class Background_Configuration_ON : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repository.
        /// </summary>
        public static global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repo = global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository.Instance;

        static Background_Configuration_ON instance = new Background_Configuration_ON();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Background_Configuration_ON()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Background_Configuration_ON Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(0));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG_Admin.Background_Configuration.mn_General_Setting' at Center.", repo.SimpleMDG_Admin.Background_Configuration.mn_General_SettingInfo, new RecordItemIndex(1));
            repo.SimpleMDG_Admin.Background_Configuration.mn_General_Setting.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG_Admin.Background_Configuration.mn_Background_Configuration' at Center.", repo.SimpleMDG_Admin.Background_Configuration.mn_Background_ConfigurationInfo, new RecordItemIndex(3));
            repo.SimpleMDG_Admin.Background_Configuration.mn_Background_Configuration.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(4));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG_Admin.Background_Configuration.btn_Edit_SLA_Priority' at Center.", repo.SimpleMDG_Admin.Background_Configuration.btn_Edit_SLA_PriorityInfo, new RecordItemIndex(5));
            repo.SimpleMDG_Admin.Background_Configuration.btn_Edit_SLA_Priority.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Set_IsActive_ON(repo.SimpleMDG_Admin.Background_Configuration.bl_IsActiveInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG_Admin.Background_Configuration.btn_Save_Update' at Center.", repo.SimpleMDG_Admin.Background_Configuration.btn_Save_UpdateInfo, new RecordItemIndex(8));
            repo.SimpleMDG_Admin.Background_Configuration.btn_Save_Update.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(9));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG_Admin.Workflow_Settings.btn_Back_Admin' at Center.", repo.SimpleMDG_Admin.Workflow_Settings.btn_Back_AdminInfo, new RecordItemIndex(10));
            repo.SimpleMDG_Admin.Workflow_Settings.btn_Back_Admin.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Enabled' to equal the specified value 'True'. Associated repository item: 'SimpleMDG_Admin.Workflow_Settings.btn_Back_Admin'", repo.SimpleMDG_Admin.Workflow_Settings.btn_Back_AdminInfo, new RecordItemIndex(11));
            repo.SimpleMDG_Admin.Workflow_Settings.btn_Back_AdminInfo.WaitForAttributeEqual(5000, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(12));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG_Admin.Workflow_Settings.mn_Template_Setting' at Center.", repo.SimpleMDG_Admin.Workflow_Settings.mn_Template_SettingInfo, new RecordItemIndex(13));
            repo.SimpleMDG_Admin.Workflow_Settings.mn_Template_Setting.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
