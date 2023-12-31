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
    ///The Select_Object_Type recording.
    /// </summary>
    [TestModule("f1d491e1-770d-471d-849e-d4ad98b2e805", ModuleType.Recording, 1)]
    public partial class Select_Object_Type : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repository.
        /// </summary>
        public static global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository repo = global::EDF__PRD_MM01.S2022_PRD_MM01_NON_DUPRepository.Instance;

        static Select_Object_Type instance = new Select_Object_Type();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_Object_Type()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_Object_Type Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varObjectType.
        /// </summary>
        [TestVariable("7654a22e-af81-4ce7-8b78-2e457af06db1")]
        public string varObjectType
        {
            get { return repo.varObjectType; }
            set { repo.varObjectType = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Master_Data.mn_Master_Data' at Center.", repo.SimpleMDG.Master_Data.mn_Master_DataInfo, new RecordItemIndex(0));
            repo.SimpleMDG.Master_Data.mn_Master_Data.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Master_Data.ckl_Select_Object_Type' at Center.", repo.SimpleMDG.Master_Data.ckl_Select_Object_TypeInfo, new RecordItemIndex(1));
            repo.SimpleMDG.Master_Data.ckl_Select_Object_Type.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(2));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Next}{Next}{Next}'.", new RecordItemIndex(3));
            Keyboard.Press("{Next}{Next}{Next}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SimpleMDG.Master_Data.mn_Choose_Object_Type' at Center.", repo.SimpleMDG.Master_Data.mn_Choose_Object_TypeInfo, new RecordItemIndex(4));
            repo.SimpleMDG.Master_Data.mn_Choose_Object_Type.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
