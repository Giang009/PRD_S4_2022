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

namespace EDF__PRD_MM01.Verify_Status
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verify_CR_Status_After_REJECTED recording.
    /// </summary>
    [TestModule("8defec68-0f0e-43a7-91bc-15c5c9b59a71", ModuleType.Recording, 1)]
    public partial class Verify_CR_Status_After_REJECTED : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repository.
        /// </summary>
        public static global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repo = global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository.Instance;

        static Verify_CR_Status_After_REJECTED instance = new Verify_CR_Status_After_REJECTED();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_CR_Status_After_REJECTED()
        {
            varCR_Number = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_CR_Status_After_REJECTED Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varCR_Number.
        /// </summary>
        [TestVariable("b824cd9d-3010-43ac-9296-1d38d3d7fcb5")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Copy_CR.txt_Search_CR' at Center.", repo.SimpleMDG.Copy_CR.txt_Search_CRInfo, new RecordItemIndex(0));
            repo.SimpleMDG.Copy_CR.txt_Search_CR.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SimpleMDG.Copy_CR.txt_Search_CR'.", repo.SimpleMDG.Copy_CR.txt_Search_CRInfo, new RecordItemIndex(1));
            repo.SimpleMDG.Copy_CR.txt_Search_CR.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varCR_Number' with focus on 'SimpleMDG.Copy_CR.txt_Search_CR'.", repo.SimpleMDG.Copy_CR.txt_Search_CRInfo, new RecordItemIndex(2));
            repo.SimpleMDG.Copy_CR.txt_Search_CR.PressKeys(varCR_Number);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Copy_CR.btn_Search_CR_Action' at Center.", repo.SimpleMDG.Copy_CR.btn_Search_CR_ActionInfo, new RecordItemIndex(3));
            repo.SimpleMDG.Copy_CR.btn_Search_CR_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(4));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (innertext='REJECTED') on item 'SimpleMDG.Copy_CR.lb_Status_REJECTED'.", repo.SimpleMDG.Copy_CR.lb_Status_REJECTEDInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.SimpleMDG.Copy_CR.lb_Status_REJECTEDInfo, "innertext", "REJECTED");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (innertext='') on item 'SimpleMDG.Copy_CR.lb_Activate_Status_blank'.", repo.SimpleMDG.Copy_CR.lb_Activate_Status_blankInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.SimpleMDG.Copy_CR.lb_Activate_Status_blankInfo, "innertext", "");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
