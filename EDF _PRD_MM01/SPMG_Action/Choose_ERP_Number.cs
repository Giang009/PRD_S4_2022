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
    ///The Choose_ERP_Number recording.
    /// </summary>
    [TestModule("e2b83201-4fa8-498c-b75b-3a037d93a102", ModuleType.Recording, 1)]
    public partial class Choose_ERP_Number : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repository.
        /// </summary>
        public static global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repo = global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository.Instance;

        static Choose_ERP_Number instance = new Choose_ERP_Number();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Choose_ERP_Number()
        {
            varMaterial_Number = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Choose_ERP_Number Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varMaterial_Number.
        /// </summary>
        [TestVariable("32d4f20e-32a8-478e-9e9d-e4682fcc8ed1")]
        public string varMaterial_Number
        {
            get { return repo.varMaterial_Number; }
            set { repo.varMaterial_Number = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(0));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SimpleMDG.Master_Data.txt_ERP_Number'", repo.SimpleMDG.Master_Data.txt_ERP_NumberInfo, new ActionTimeout(5000), new RecordItemIndex(1));
            repo.SimpleMDG.Master_Data.txt_ERP_NumberInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Master_Data.txt_ERP_Number' at Center.", repo.SimpleMDG.Master_Data.txt_ERP_NumberInfo, new RecordItemIndex(2));
            repo.SimpleMDG.Master_Data.txt_ERP_Number.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varMaterial_Number' with focus on 'SimpleMDG.Master_Data.txt_ERP_Number'.", repo.SimpleMDG.Master_Data.txt_ERP_NumberInfo, new RecordItemIndex(3));
            repo.SimpleMDG.Master_Data.txt_ERP_Number.PressKeys(varMaterial_Number);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Master_Data.btn_Search_ERP' at Center.", repo.SimpleMDG.Master_Data.btn_Search_ERPInfo, new RecordItemIndex(4));
            repo.SimpleMDG.Master_Data.btn_Search_ERP.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(5));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$varMaterial_Number) on item 'SimpleMDG.Master_Data.lb_Verify_ERP_Number'.", repo.SimpleMDG.Master_Data.lb_Verify_ERP_NumberInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.SimpleMDG.Master_Data.lb_Verify_ERP_NumberInfo, "InnerText", varMaterial_Number);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
