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
    ///The Save_Draft recording.
    /// </summary>
    [TestModule("9d2d83e8-0452-46ee-ab64-853cdf4400f0", ModuleType.Recording, 1)]
    public partial class Save_Draft : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repository.
        /// </summary>
        public static global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repo = global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository.Instance;

        static Save_Draft instance = new Save_Draft();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Save_Draft()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Save_Draft Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varRequestDes.
        /// </summary>
        [TestVariable("91235f9a-a657-4787-ab5b-a37971a37596")]
        public string varRequestDes
        {
            get { return repo.varRequestDes; }
            set { repo.varRequestDes = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Select_Template.btn_Save_as_Draft' at Center.", repo.SimpleMDG.Select_Template.btn_Save_as_DraftInfo, new RecordItemIndex(0));
            repo.SimpleMDG.Select_Template.btn_Save_as_Draft.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Select_Template.btn_NOT_save_image' at Center.", repo.SimpleMDG.Select_Template.btn_NOT_save_imageInfo, new RecordItemIndex(1));
            repo.SimpleMDG.Select_Template.btn_NOT_save_image.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(2));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SimpleMDG.Select_Template.btn_See_Draft'", repo.SimpleMDG.Select_Template.btn_See_DraftInfo, new ActionTimeout(10000), new RecordItemIndex(3));
            repo.SimpleMDG.Select_Template.btn_See_DraftInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Select_Template.btn_See_Draft' at Center.", repo.SimpleMDG.Select_Template.btn_See_DraftInfo, new RecordItemIndex(4));
            repo.SimpleMDG.Select_Template.btn_See_Draft.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(5));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Select_Template.lb_Select_Draft_CR' at Center.", repo.SimpleMDG.Select_Template.lb_Select_Draft_CRInfo, new RecordItemIndex(6));
            repo.SimpleMDG.Select_Template.lb_Select_Draft_CR.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SimpleMDG.Submit_CR.btn_SubmitCR'", repo.SimpleMDG.Submit_CR.btn_SubmitCRInfo, new ActionTimeout(10000), new RecordItemIndex(8));
            repo.SimpleMDG.Submit_CR.btn_SubmitCRInfo.WaitForExists(10000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
