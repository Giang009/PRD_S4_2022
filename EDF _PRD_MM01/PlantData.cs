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
    ///The PlantData recording.
    /// </summary>
    [TestModule("e1091624-2102-466b-a415-87d72f6e18eb", ModuleType.Recording, 1)]
    public partial class PlantData : ITestModule
    {
        /// <summary>
        /// Holds an instance of the EDF__PRD_MM01Repository repository.
        /// </summary>
        public static EDF__PRD_MM01Repository repo = EDF__PRD_MM01Repository.Instance;

        static PlantData instance = new PlantData();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PlantData()
        {
            varPlant = "";
            varCosting_Lot_Size = "";
            varPackaging_Mode = "";
            varMRP_Group = "";
            varMRP_Type = "";
            varMRP_Controller = "";
            varLot_Sizing_Procedure = "";
            varMaximum_Stock_Level = "";
            varProcurement_Type = "";
            varBackflush = "";
            varProduction_Time = "";
            varPeriod_Indicator = "";
            varProfit_Center = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PlantData Instance
        {
            get { return instance; }
        }

#region Variables

        string _varCosting_Lot_Size;

        /// <summary>
        /// Gets or sets the value of variable varCosting_Lot_Size.
        /// </summary>
        [TestVariable("e7bb9d17-b60e-458a-8f1d-668e8941f08d")]
        public string varCosting_Lot_Size
        {
            get { return _varCosting_Lot_Size; }
            set { _varCosting_Lot_Size = value; }
        }

        string _varLot_Sizing_Procedure;

        /// <summary>
        /// Gets or sets the value of variable varLot_Sizing_Procedure.
        /// </summary>
        [TestVariable("b416d0a6-4e91-4cd6-b1a9-1cb5db3a4bbf")]
        public string varLot_Sizing_Procedure
        {
            get { return _varLot_Sizing_Procedure; }
            set { _varLot_Sizing_Procedure = value; }
        }

        string _varMaximum_Stock_Level;

        /// <summary>
        /// Gets or sets the value of variable varMaximum_Stock_Level.
        /// </summary>
        [TestVariable("5765c413-2f50-40b4-835d-2bd78bf463f8")]
        public string varMaximum_Stock_Level
        {
            get { return _varMaximum_Stock_Level; }
            set { _varMaximum_Stock_Level = value; }
        }

        string _varProcurement_Type;

        /// <summary>
        /// Gets or sets the value of variable varProcurement_Type.
        /// </summary>
        [TestVariable("a6027474-45e5-49db-bdf8-10adc165fcea")]
        public string varProcurement_Type
        {
            get { return _varProcurement_Type; }
            set { _varProcurement_Type = value; }
        }

        string _varBackflush;

        /// <summary>
        /// Gets or sets the value of variable varBackflush.
        /// </summary>
        [TestVariable("f92b5266-ec3f-4556-b2f7-2639f8a0d1e3")]
        public string varBackflush
        {
            get { return _varBackflush; }
            set { _varBackflush = value; }
        }

        string _varProduction_Time;

        /// <summary>
        /// Gets or sets the value of variable varProduction_Time.
        /// </summary>
        [TestVariable("3abee941-a519-4c9f-a00e-a603f5207dc7")]
        public string varProduction_Time
        {
            get { return _varProduction_Time; }
            set { _varProduction_Time = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varPlant.
        /// </summary>
        [TestVariable("9919b04d-28a1-4fc4-a00f-44284fbf0e47")]
        public string varPlant
        {
            get { return repo.varPlant; }
            set { repo.varPlant = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varPackaging_Mode.
        /// </summary>
        [TestVariable("7af73f9a-9c45-4c67-a3ea-a25298d55e2c")]
        public string varPackaging_Mode
        {
            get { return repo.varPackaging_Mode; }
            set { repo.varPackaging_Mode = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varProfit_Center.
        /// </summary>
        [TestVariable("de6d76dc-034e-4c86-b263-b507f2c27a10")]
        public string varProfit_Center
        {
            get { return repo.varProfit_Center; }
            set { repo.varProfit_Center = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varMRP_Group.
        /// </summary>
        [TestVariable("b8df48f5-dcd4-4900-9a7b-2761cee027e6")]
        public string varMRP_Group
        {
            get { return repo.varMRP_Group; }
            set { repo.varMRP_Group = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varMRP_Type.
        /// </summary>
        [TestVariable("9eaf8090-c309-4d1c-8bd0-966b68223d5e")]
        public string varMRP_Type
        {
            get { return repo.varMRP_Type; }
            set { repo.varMRP_Type = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varMRP_Controller.
        /// </summary>
        [TestVariable("9c614675-8202-4e8e-a6c8-e2ec47d10991")]
        public string varMRP_Controller
        {
            get { return repo.varMRP_Controller; }
            set { repo.varMRP_Controller = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varPeriod_Indicator.
        /// </summary>
        [TestVariable("0fc5cbc0-8296-4a23-b5f0-b2cd0463a591")]
        public string varPeriod_Indicator
        {
            get { return repo.varPeriod_Indicator; }
            set { repo.varPeriod_Indicator = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.menu_Plant_Data' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.menu_Plant_DataInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.menu_Plant_Data.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.btn_Add_Plant_Data' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Add_Plant_DataInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Add_Plant_Data.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Plant_Data' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Plant_DataInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Plant_Data.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varPlant' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Plant_Data'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Plant_DataInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Plant_Data.PressKeys(varPlant);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Plant_Data_Action' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Plant_Data_ActionInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Plant_Data_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Plant_Data' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Plant_DataInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Plant_Data.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varCosting_Lot_Size' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Costing_Lot_Size'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Costing_Lot_SizeInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Costing_Lot_Size.PressKeys(varCosting_Lot_Size);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Purchasing_Group' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Purchasing_GroupInfo, new RecordItemIndex(7));
            //repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Purchasing_Group.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '104' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Purchasing_Group'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Purchasing_GroupInfo, new RecordItemIndex(8));
            //repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Purchasing_Group.PressKeys("104");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Purchasing_Group_Action' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Purchasing_Group_ActionInfo, new RecordItemIndex(9));
            //repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Purchasing_Group_Action.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Purchasing_Group' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Purchasing_GroupInfo, new RecordItemIndex(10));
            //repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Purchasing_Group.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.chk_Kanban_Flag' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.chk_Kanban_FlagInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.chk_Kanban_Flag.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Packaging_Mode' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Packaging_ModeInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Packaging_Mode.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varPackaging_Mode' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Packaging_Mode'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Packaging_ModeInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Packaging_Mode.PressKeys(varPackaging_Mode);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Packaging_Mode_Action' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Packaging_Mode_ActionInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Packaging_Mode_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Packaging_Mode' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Packaging_ModeInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Packaging_Mode.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Profit_Center' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Profit_CenterInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Profit_Center.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varProfit_Center' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Profit_Center'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Profit_CenterInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Profit_Center.PressKeys(varProfit_Center);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Profit_Center_Action' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Profit_Center_ActionInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Profit_Center_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Profit_Center' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Profit_CenterInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Profit_Center.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.chk_Batch_Management' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.chk_Batch_ManagementInfo, new RecordItemIndex(20));
            //repo.ApplicationUnderTest.Input_Data.Plant_Data.chk_Batch_Management.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.menu_MRP_1' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.menu_MRP_1Info, new RecordItemIndex(21));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.menu_MRP_1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.txt_MRP_Group' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_MRP_GroupInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_MRP_Group.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varMRP_Group' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_MRP_Group'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_MRP_GroupInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_MRP_Group.PressKeys(varMRP_Group);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.bnt_Search_MRP_Group_Action' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.bnt_Search_MRP_Group_ActionInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.bnt_Search_MRP_Group_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_MRP_Group' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_MRP_GroupInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_MRP_Group.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.txt_MRP_Type' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_MRP_TypeInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_MRP_Type.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varMRP_Type' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_MRP_Type'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_MRP_TypeInfo, new RecordItemIndex(27));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_MRP_Type.PressKeys(varMRP_Type);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_MRP_Type_Action' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_MRP_Type_ActionInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_MRP_Type_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_MRP_Type' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_MRP_TypeInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_MRP_Type.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.txt_MRP_Controller' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_MRP_ControllerInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_MRP_Controller.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varMRP_Controller' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_MRP_Controller'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_MRP_ControllerInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_MRP_Controller.PressKeys(varMRP_Controller);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_MRP_Controller_Action' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_MRP_Controller_ActionInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_MRP_Controller_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_MRP_Controller' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_MRP_ControllerInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_MRP_Controller.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varLot_Sizing_Procedure' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Lot_Sizing_Procedure'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Lot_Sizing_ProcedureInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Lot_Sizing_Procedure.PressKeys(varLot_Sizing_Procedure);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varMaximum_Stock_Level' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Maximum_Stock_Level'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Maximum_Stock_LevelInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Maximum_Stock_Level.PressKeys(varMaximum_Stock_Level);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.menu_MRP_2' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.menu_MRP_2Info, new RecordItemIndex(36));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.menu_MRP_2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varProcurement_Type' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Procurement_Type'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Procurement_TypeInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Procurement_Type.PressKeys(varProcurement_Type);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varBackflush' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Backflush'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_BackflushInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Backflush.PressKeys(varBackflush);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varProduction_Time' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_In_House_Production_Time'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_In_House_Production_TimeInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_In_House_Production_Time.PressKeys(varProduction_Time);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.menu_MRP_3' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.menu_MRP_3Info, new RecordItemIndex(40));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.menu_MRP_3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Period_Indicator' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Period_IndicatorInfo, new RecordItemIndex(41));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Period_Indicator.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varPeriod_Indicator' with focus on 'ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Period_Indicator'.", repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Period_IndicatorInfo, new RecordItemIndex(42));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.txt_Search_Period_Indicator.PressKeys(varPeriod_Indicator);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Period_Indicator_Action' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Period_Indicator_ActionInfo, new RecordItemIndex(43));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_Search_Period_Indicator_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Period_Indicator' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Period_IndicatorInfo, new RecordItemIndex(44));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.lb_Select_Period_Indicator.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.Plant_Data.btn_ADD_Plant' at Center.", repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_ADD_PlantInfo, new RecordItemIndex(45));
            repo.ApplicationUnderTest.Input_Data.Plant_Data.btn_ADD_Plant.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}