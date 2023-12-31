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

namespace EDF__PRD_MM01
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Input_Header recording.
    /// </summary>
    [TestModule("b3b951cb-c227-4e63-966b-3a4c0916500e", ModuleType.Recording, 1)]
    public partial class Input_Header : ITestModule
    {
        /// <summary>
        /// Holds an instance of the EDF__PRD_MM01Repository repository.
        /// </summary>
        public static EDF__PRD_MM01Repository repo = EDF__PRD_MM01Repository.Instance;

        static Input_Header instance = new Input_Header();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Input_Header()
        {
            varRequestDes = "";
            varReason = "";
            varOtherReason = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Input_Header Instance
        {
            get { return instance; }
        }

#region Variables

        string _varRequestDes;

        /// <summary>
        /// Gets or sets the value of variable varRequestDes.
        /// </summary>
        [TestVariable("8048d1a0-81ef-4574-8e40-e94d71736183")]
        public string varRequestDes
        {
            get { return _varRequestDes; }
            set { _varRequestDes = value; }
        }

        string _varReason;

        /// <summary>
        /// Gets or sets the value of variable varReason.
        /// </summary>
        [TestVariable("43c6c6be-87a1-41d5-a19a-0716f0dd609f")]
        public string varReason
        {
            get { return _varReason; }
            set { _varReason = value; }
        }

        string _varOtherReason;

        /// <summary>
        /// Gets or sets the value of variable varOtherReason.
        /// </summary>
        [TestVariable("1f0886a1-baaa-48a1-8c62-7f809aca8f4a")]
        public string varOtherReason
        {
            get { return _varOtherReason; }
            set { _varOtherReason = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varPriority.
        /// </summary>
        [TestVariable("44945af1-efde-430d-b0aa-02151729f98f")]
        public string varPriority
        {
            get { return repo.varPriority; }
            set { repo.varPriority = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Header.txt_Description' at Center.", repo.ApplicationUnderTest.Header.txt_DescriptionInfo, new RecordItemIndex(0));
            //repo.ApplicationUnderTest.Header.txt_Description.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varRequestDes' with focus on 'ApplicationUnderTest.Header.txt_Description'.", repo.ApplicationUnderTest.Header.txt_DescriptionInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Header.txt_Description.PressKeys(varRequestDes);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Header.ckl_Priority' at Center.", repo.ApplicationUnderTest.Header.ckl_PriorityInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Header.ckl_Priority.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Header.list_Priority' at Center.", repo.ApplicationUnderTest.Header.list_PriorityInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Header.list_Priority.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Header.txt_Reason' at Center.", repo.ApplicationUnderTest.Header.txt_ReasonInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.Header.txt_Reason.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varReason' with focus on 'ApplicationUnderTest.Header.txt_Reason'.", repo.ApplicationUnderTest.Header.txt_ReasonInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Header.txt_Reason.PressKeys(varReason);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Header.txt_OtherReason' at Center.", repo.ApplicationUnderTest.Header.txt_OtherReasonInfo, new RecordItemIndex(6));
            //repo.ApplicationUnderTest.Header.txt_OtherReason.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varOtherReason' with focus on 'ApplicationUnderTest.Header.txt_OtherReason'.", repo.ApplicationUnderTest.Header.txt_OtherReasonInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.Header.txt_OtherReason.PressKeys(varOtherReason);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
