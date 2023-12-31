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

namespace EDF__PRD_MM01.Approval
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Approval_APPROVAL_REWORK recording.
    /// </summary>
    [TestModule("612c0cf3-1674-48c0-878c-6008e42edd09", ModuleType.Recording, 1)]
    public partial class Approval_APPROVAL_REWORK : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repository.
        /// </summary>
        public static global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repo = global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository.Instance;

        static Approval_APPROVAL_REWORK instance = new Approval_APPROVAL_REWORK();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Approval_APPROVAL_REWORK()
        {
            varCR_Number = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Approval_APPROVAL_REWORK Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varCR_Number.
        /// </summary>
        [TestVariable("2d5ecfc7-5ec4-4ffc-92e1-75dd8009b548")]
        public string varCR_Number
        {
            get { return repo.varCR_Number; }
            set { repo.varCR_Number = value; }
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
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(0));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Menu.mn_MyTasks' at Center.", repo.SimpleMDG.Menu.mn_MyTasksInfo, new RecordItemIndex(1));
            repo.SimpleMDG.Menu.mn_MyTasks.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Menu.mn_My_Inbox' at Center.", repo.SimpleMDG.Menu.mn_My_InboxInfo, new RecordItemIndex(2));
            repo.SimpleMDG.Menu.mn_My_Inbox.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SimpleMDG.Approval.txt_Search_CR'", repo.SimpleMDG.Approval.txt_Search_CRInfo, new ActionTimeout(10000), new RecordItemIndex(3));
            repo.SimpleMDG.Approval.txt_Search_CRInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Approval.txt_Search_CR' at Center.", repo.SimpleMDG.Approval.txt_Search_CRInfo, new RecordItemIndex(4));
            repo.SimpleMDG.Approval.txt_Search_CR.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(5));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SimpleMDG.Approval.txt_Search_CR'.", repo.SimpleMDG.Approval.txt_Search_CRInfo, new RecordItemIndex(6));
            repo.SimpleMDG.Approval.txt_Search_CR.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varCR_Number' with focus on 'SimpleMDG.Approval.txt_Search_CR'.", repo.SimpleMDG.Approval.txt_Search_CRInfo, new RecordItemIndex(8));
            repo.SimpleMDG.Approval.txt_Search_CR.PressKeys(varCR_Number);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Approval.btn_Search_CR_Action' at Center.", repo.SimpleMDG.Approval.btn_Search_CR_ActionInfo, new RecordItemIndex(9));
            repo.SimpleMDG.Approval.btn_Search_CR_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(10));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Approval.lb_Select_CR' at Center.", repo.SimpleMDG.Approval.lb_Select_CRInfo, new RecordItemIndex(11));
            repo.SimpleMDG.Approval.lb_Select_CR.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(12));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Approval.btn_Approve' at Center.", repo.SimpleMDG.Approval.btn_ApproveInfo, new RecordItemIndex(13));
            repo.SimpleMDG.Approval.btn_Approve.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SimpleMDG.Approval.txt_Comment_Approval'", repo.SimpleMDG.Approval.txt_Comment_ApprovalInfo, new ActionTimeout(5000), new RecordItemIndex(14));
            repo.SimpleMDG.Approval.txt_Comment_ApprovalInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AT Ranorex Approval with the first time' with focus on 'SimpleMDG.Approval.txt_Comment_Approval'.", repo.SimpleMDG.Approval.txt_Comment_ApprovalInfo, new RecordItemIndex(15));
            repo.SimpleMDG.Approval.txt_Comment_Approval.PressKeys("AT Ranorex Approval with the first time");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Approval.btn_Approve_Confirm' at Center.", repo.SimpleMDG.Approval.btn_Approve_ConfirmInfo, new RecordItemIndex(16));
            repo.SimpleMDG.Approval.btn_Approve_Confirm.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(17));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SimpleMDG.Approval.txt_Search_CR'", repo.SimpleMDG.Approval.txt_Search_CRInfo, new ActionTimeout(10000), new RecordItemIndex(18));
            repo.SimpleMDG.Approval.txt_Search_CRInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Approval.txt_Search_CR' at Center.", repo.SimpleMDG.Approval.txt_Search_CRInfo, new RecordItemIndex(19));
            repo.SimpleMDG.Approval.txt_Search_CR.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(20));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SimpleMDG.Approval.txt_Search_CR'.", repo.SimpleMDG.Approval.txt_Search_CRInfo, new RecordItemIndex(21));
            repo.SimpleMDG.Approval.txt_Search_CR.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(22));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varCR_Number' with focus on 'SimpleMDG.Approval.txt_Search_CR'.", repo.SimpleMDG.Approval.txt_Search_CRInfo, new RecordItemIndex(23));
            repo.SimpleMDG.Approval.txt_Search_CR.PressKeys(varCR_Number);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Approval.btn_Search_CR_Action' at Center.", repo.SimpleMDG.Approval.btn_Search_CR_ActionInfo, new RecordItemIndex(24));
            repo.SimpleMDG.Approval.btn_Search_CR_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(25));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Approval.lb_Select_CR' at Center.", repo.SimpleMDG.Approval.lb_Select_CRInfo, new RecordItemIndex(26));
            repo.SimpleMDG.Approval.lb_Select_CR.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(27));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Approval.btn_Rework' at Center.", repo.SimpleMDG.Approval.btn_ReworkInfo, new RecordItemIndex(28));
            repo.SimpleMDG.Approval.btn_Rework.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Approval.btn_Rework_by_Requestor' at Center.", repo.SimpleMDG.Approval.btn_Rework_by_RequestorInfo, new RecordItemIndex(29));
            repo.SimpleMDG.Approval.btn_Rework_by_Requestor.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(30));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AT Ranorex Approval with Rework a Duplication CR' with focus on 'SimpleMDG.Approval.txt_Comment_Approval'.", repo.SimpleMDG.Approval.txt_Comment_ApprovalInfo, new RecordItemIndex(31));
            repo.SimpleMDG.Approval.txt_Comment_Approval.PressKeys("AT Ranorex Approval with Rework a Duplication CR");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Approval.btn_Rework_Confirm' at Center.", repo.SimpleMDG.Approval.btn_Rework_ConfirmInfo, new RecordItemIndex(32));
            repo.SimpleMDG.Approval.btn_Rework_Confirm.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(33));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
