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

namespace EDF__PRD_MM01.Steward
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Stewards_Active_NON_DUP recording.
    /// </summary>
    [TestModule("2ddf4aa7-e282-4c7c-b94d-6c25bfce12d0", ModuleType.Recording, 1)]
    public partial class Stewards_Active_NON_DUP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repository.
        /// </summary>
        public static global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repo = global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository.Instance;

        static Stewards_Active_NON_DUP instance = new Stewards_Active_NON_DUP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Stewards_Active_NON_DUP()
        {
            varCR_Number = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Stewards_Active_NON_DUP Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varCR_Number.
        /// </summary>
        [TestVariable("0c52481b-d5f3-415f-85d9-1ad38da55f2c")]
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(0));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Stewards.mn_Stewards' at Center.", repo.SimpleMDG.Stewards.mn_StewardsInfo, new RecordItemIndex(1));
            repo.SimpleMDG.Stewards.mn_Stewards.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(2));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Stewards.mn_Activation_Requests' at Center.", repo.SimpleMDG.Stewards.mn_Activation_RequestsInfo, new RecordItemIndex(3));
            repo.SimpleMDG.Stewards.mn_Activation_Requests.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(4));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SimpleMDG.Stewards.txt_Search_CR'", repo.SimpleMDG.Stewards.txt_Search_CRInfo, new ActionTimeout(20000), new RecordItemIndex(5));
            repo.SimpleMDG.Stewards.txt_Search_CRInfo.WaitForExists(20000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Stewards.txt_Search_CR' at Center.", repo.SimpleMDG.Stewards.txt_Search_CRInfo, new RecordItemIndex(6));
            repo.SimpleMDG.Stewards.txt_Search_CR.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SimpleMDG.Stewards.txt_Search_CR'.", repo.SimpleMDG.Stewards.txt_Search_CRInfo, new RecordItemIndex(7));
            repo.SimpleMDG.Stewards.txt_Search_CR.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varCR_Number' with focus on 'SimpleMDG.Stewards.txt_Search_CR'.", repo.SimpleMDG.Stewards.txt_Search_CRInfo, new RecordItemIndex(8));
            repo.SimpleMDG.Stewards.txt_Search_CR.PressKeys(varCR_Number);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Stewards.btn_Search_CR_Action' at Center.", repo.SimpleMDG.Stewards.btn_Search_CR_ActionInfo, new RecordItemIndex(9));
            repo.SimpleMDG.Stewards.btn_Search_CR_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(10));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SimpleMDG.Stewards.btn_menu_Option'", repo.SimpleMDG.Stewards.btn_menu_OptionInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            repo.SimpleMDG.Stewards.btn_menu_OptionInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Enabled' to equal the specified value 'True'. Associated repository item: 'SimpleMDG.Stewards.btn_menu_Option'", repo.SimpleMDG.Stewards.btn_menu_OptionInfo, new RecordItemIndex(12));
            repo.SimpleMDG.Stewards.btn_menu_OptionInfo.WaitForAttributeEqual(5000, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Stewards.btn_menu_Option' at Center.", repo.SimpleMDG.Stewards.btn_menu_OptionInfo, new RecordItemIndex(13));
            repo.SimpleMDG.Stewards.btn_menu_Option.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Stewards.mn_Assign_to_me' at Center.", repo.SimpleMDG.Stewards.mn_Assign_to_meInfo, new RecordItemIndex(14));
            repo.SimpleMDG.Stewards.mn_Assign_to_me.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(15));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SimpleMDG.Stewards.lb_Status_ASSIGNED'", repo.SimpleMDG.Stewards.lb_Status_ASSIGNEDInfo, new ActionTimeout(30000), new RecordItemIndex(16));
            repo.SimpleMDG.Stewards.lb_Status_ASSIGNEDInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SimpleMDG.Stewards.btn_menu_Option'", repo.SimpleMDG.Stewards.btn_menu_OptionInfo, new ActionTimeout(30000), new RecordItemIndex(17));
            repo.SimpleMDG.Stewards.btn_menu_OptionInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Enabled' to equal the specified value 'True'. Associated repository item: 'SimpleMDG.Stewards.btn_menu_Option'", repo.SimpleMDG.Stewards.btn_menu_OptionInfo, new RecordItemIndex(18));
            repo.SimpleMDG.Stewards.btn_menu_OptionInfo.WaitForAttributeEqual(5000, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(19));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Stewards.btn_menu_Option' at Center.", repo.SimpleMDG.Stewards.btn_menu_OptionInfo, new RecordItemIndex(20));
            repo.SimpleMDG.Stewards.btn_menu_Option.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Stewards.mn_Approval' at Center.", repo.SimpleMDG.Stewards.mn_ApprovalInfo, new RecordItemIndex(21));
            repo.SimpleMDG.Stewards.mn_Approval.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(22));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Stewards.btn_OK_Confirm' at Center.", repo.SimpleMDG.Stewards.btn_OK_ConfirmInfo, new RecordItemIndex(23));
            repo.SimpleMDG.Stewards.btn_OK_Confirm.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(24));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SimpleMDG.Stewards.lb_Status_ACTIVATED'", repo.SimpleMDG.Stewards.lb_Status_ACTIVATEDInfo, new ActionTimeout(30000), new RecordItemIndex(25));
            repo.SimpleMDG.Stewards.lb_Status_ACTIVATEDInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}