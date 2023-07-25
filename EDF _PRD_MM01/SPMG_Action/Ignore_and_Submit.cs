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
    ///The Ignore_and_Submit recording.
    /// </summary>
    [TestModule("1983540d-71c9-4673-a94c-e6148473e9ac", ModuleType.Recording, 1)]
    public partial class Ignore_and_Submit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repository.
        /// </summary>
        public static global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repo = global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository.Instance;

        static Ignore_and_Submit instance = new Ignore_and_Submit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ignore_and_Submit()
        {
            varCR_Number = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ignore_and_Submit Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varCR_Number.
        /// </summary>
        [TestVariable("f16cc06f-dcfa-4a23-bf7f-a4da197b0162")]
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SimpleMDG.Copy_CR.txt_Search_CR'", repo.SimpleMDG.Copy_CR.txt_Search_CRInfo, new ActionTimeout(5000), new RecordItemIndex(0));
            repo.SimpleMDG.Copy_CR.txt_Search_CRInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Copy_CR.txt_Search_CR' at Center.", repo.SimpleMDG.Copy_CR.txt_Search_CRInfo, new RecordItemIndex(1));
            repo.SimpleMDG.Copy_CR.txt_Search_CR.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SimpleMDG.Copy_CR.txt_Search_CR'.", repo.SimpleMDG.Copy_CR.txt_Search_CRInfo, new RecordItemIndex(3));
            repo.SimpleMDG.Copy_CR.txt_Search_CR.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varCR_Number' with focus on 'SimpleMDG.Copy_CR.txt_Search_CR'.", repo.SimpleMDG.Copy_CR.txt_Search_CRInfo, new RecordItemIndex(4));
            repo.SimpleMDG.Copy_CR.txt_Search_CR.PressKeys(varCR_Number);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Copy_CR.btn_Search_CR_Action' at Center.", repo.SimpleMDG.Copy_CR.btn_Search_CR_ActionInfo, new RecordItemIndex(5));
            repo.SimpleMDG.Copy_CR.btn_Search_CR_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(6));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SimpleMDG.Copy_CR.btn_Menu_Option'", repo.SimpleMDG.Copy_CR.btn_Menu_OptionInfo, new ActionTimeout(5000), new RecordItemIndex(7));
            repo.SimpleMDG.Copy_CR.btn_Menu_OptionInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Copy_CR.btn_Menu_Option' at Center.", repo.SimpleMDG.Copy_CR.btn_Menu_OptionInfo, new RecordItemIndex(8));
            repo.SimpleMDG.Copy_CR.btn_Menu_Option.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Copy_CR.menu_Ignore_and_Submit' at Center.", repo.SimpleMDG.Copy_CR.menu_Ignore_and_SubmitInfo, new RecordItemIndex(9));
            repo.SimpleMDG.Copy_CR.menu_Ignore_and_Submit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Copy_CR.btn_Ignore_Submit_Close' at Center.", repo.SimpleMDG.Copy_CR.btn_Ignore_Submit_CloseInfo, new RecordItemIndex(10));
            repo.SimpleMDG.Copy_CR.btn_Ignore_Submit_Close.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}