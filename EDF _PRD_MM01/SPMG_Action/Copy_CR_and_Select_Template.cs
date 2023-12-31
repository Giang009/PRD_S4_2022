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
    ///The Copy_CR_and_Select_Template recording.
    /// </summary>
    [TestModule("ec32acda-5f6b-497e-ad9b-a55058f16413", ModuleType.Recording, 1)]
    public partial class Copy_CR_and_Select_Template : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repository.
        /// </summary>
        public static global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repo = global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository.Instance;

        static Copy_CR_and_Select_Template instance = new Copy_CR_and_Select_Template();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Copy_CR_and_Select_Template()
        {
            varTemplate = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Copy_CR_and_Select_Template Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varTemplate.
        /// </summary>
        [TestVariable("eb4ca74d-491b-47fe-939a-a23dc435a781")]
        public string varTemplate
        {
            get { return repo.varTemplate; }
            set { repo.varTemplate = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SimpleMDG.Master_Data.btn_Option_Menu'", repo.SimpleMDG.Master_Data.btn_Option_MenuInfo, new ActionTimeout(5000), new RecordItemIndex(0));
            repo.SimpleMDG.Master_Data.btn_Option_MenuInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Master_Data.btn_Option_Menu' at Center.", repo.SimpleMDG.Master_Data.btn_Option_MenuInfo, new RecordItemIndex(1));
            repo.SimpleMDG.Master_Data.btn_Option_Menu.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Master_Data.mn_Copy' at Center.", repo.SimpleMDG.Master_Data.mn_CopyInfo, new RecordItemIndex(2));
            repo.SimpleMDG.Master_Data.mn_Copy.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(3));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'SimpleMDG.Select_Template.btn_SwitchTemplates'", repo.SimpleMDG.Select_Template.btn_SwitchTemplatesInfo, new ActionTimeout(15000), new RecordItemIndex(4));
            repo.SimpleMDG.Select_Template.btn_SwitchTemplatesInfo.WaitForExists(15000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Select_Template.btn_SwitchTemplates' at Center.", repo.SimpleMDG.Select_Template.btn_SwitchTemplatesInfo, new RecordItemIndex(6));
            repo.SimpleMDG.Select_Template.btn_SwitchTemplates.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varTemplate' with focus on 'SimpleMDG.Select_Template.txt_Search_Template'.", repo.SimpleMDG.Select_Template.txt_Search_TemplateInfo, new RecordItemIndex(8));
            repo.SimpleMDG.Select_Template.txt_Search_Template.PressKeys(varTemplate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Select_Template.btn_Search_Action' at Center.", repo.SimpleMDG.Select_Template.btn_Search_ActionInfo, new RecordItemIndex(9));
            repo.SimpleMDG.Select_Template.btn_Search_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Select_Template.lb_Select_Template' at Center.", repo.SimpleMDG.Select_Template.lb_Select_TemplateInfo, new RecordItemIndex(10));
            repo.SimpleMDG.Select_Template.lb_Select_Template.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
