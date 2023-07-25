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
    ///The GeneralData recording.
    /// </summary>
    [TestModule("421dc374-2afa-4f53-9901-a70cfee15ccc", ModuleType.Recording, 1)]
    public partial class GeneralData : ITestModule
    {
        /// <summary>
        /// Holds an instance of the EDF__PRD_MM01Repository repository.
        /// </summary>
        public static EDF__PRD_MM01Repository repo = EDF__PRD_MM01Repository.Instance;

        static GeneralData instance = new GeneralData();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GeneralData()
        {
            varUnit_of_Measure = "";
            varLaboratory = "";
            varOld_material = "";
            varPage_Format = "";
            varProduct_Hierarchy = "";
            varLength = "";
            varWidth = "";
            varHeight = "";
            varUnit = "";
            varPage_Number = "";
            varX_Plant = "";
            varValid_from = "";
            varPackaging_Materials = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GeneralData Instance
        {
            get { return instance; }
        }

#region Variables

        string _varOld_material;

        /// <summary>
        /// Gets or sets the value of variable varOld_material.
        /// </summary>
        [TestVariable("0e8d4c83-a805-4488-8958-71358c1e2298")]
        public string varOld_material
        {
            get { return _varOld_material; }
            set { _varOld_material = value; }
        }

        string _varPage_Format;

        /// <summary>
        /// Gets or sets the value of variable varPage_Format.
        /// </summary>
        [TestVariable("0db1f487-ec5d-422c-9dbe-d170050162be")]
        public string varPage_Format
        {
            get { return _varPage_Format; }
            set { _varPage_Format = value; }
        }

        string _varLength;

        /// <summary>
        /// Gets or sets the value of variable varLength.
        /// </summary>
        [TestVariable("338af749-fa94-4a16-a861-ee3dfe2f3fcc")]
        public string varLength
        {
            get { return _varLength; }
            set { _varLength = value; }
        }

        string _varWidth;

        /// <summary>
        /// Gets or sets the value of variable varWidth.
        /// </summary>
        [TestVariable("f14531a7-a212-4091-912f-2328bfe53ec4")]
        public string varWidth
        {
            get { return _varWidth; }
            set { _varWidth = value; }
        }

        string _varHeight;

        /// <summary>
        /// Gets or sets the value of variable varHeight.
        /// </summary>
        [TestVariable("becd10ae-a67a-4c48-9087-1ee6d97990fe")]
        public string varHeight
        {
            get { return _varHeight; }
            set { _varHeight = value; }
        }

        string _varPage_Number;

        /// <summary>
        /// Gets or sets the value of variable varPage_Number.
        /// </summary>
        [TestVariable("954b42d2-792d-40a6-bf39-b87438afc27e")]
        public string varPage_Number
        {
            get { return _varPage_Number; }
            set { _varPage_Number = value; }
        }

        string _varValid_from;

        /// <summary>
        /// Gets or sets the value of variable varValid_from.
        /// </summary>
        [TestVariable("6c03ebe7-38a2-437b-82e7-c0eb0f5091b6")]
        public string varValid_from
        {
            get { return _varValid_from; }
            set { _varValid_from = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varUnit_of_Measure.
        /// </summary>
        [TestVariable("cebad0a0-a0f5-4238-824c-c790125995af")]
        public string varUnit_of_Measure
        {
            get { return repo.varUnit_of_Measure; }
            set { repo.varUnit_of_Measure = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varLaboratory.
        /// </summary>
        [TestVariable("89df9b6b-5f02-4568-92b6-d76f73b33b44")]
        public string varLaboratory
        {
            get { return repo.varLaboratory; }
            set { repo.varLaboratory = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varProduct_Hierarchy.
        /// </summary>
        [TestVariable("8c7f4b47-4e96-44df-ab49-c3ce9c294a73")]
        public string varProduct_Hierarchy
        {
            get { return repo.varProduct_Hierarchy; }
            set { repo.varProduct_Hierarchy = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varUnit.
        /// </summary>
        [TestVariable("0c7d6e36-9511-400f-a0e3-bf25bb670464")]
        public string varUnit
        {
            get { return repo.varUnit; }
            set { repo.varUnit = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varX_Plant.
        /// </summary>
        [TestVariable("8fc5e46c-b219-47f3-9f95-b60fe53059cd")]
        public string varX_Plant
        {
            get { return repo.varX_Plant; }
            set { repo.varX_Plant = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varPackaging_Materials.
        /// </summary>
        [TestVariable("aa48c6df-dc8d-4b91-8a19-8144d9918761")]
        public string varPackaging_Materials
        {
            get { return repo.varPackaging_Materials; }
            set { repo.varPackaging_Materials = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.menu_Basic_Data' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.menu_Basic_DataInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Input_Data.General_Data.menu_Basic_Data.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Unit_of_Measure' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Unit_of_MeasureInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Unit_of_Measure.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_SearchUnit_Of_Measure' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_SearchUnit_Of_MeasureInfo, new RecordItemIndex(2));
            //repo.ApplicationUnderTest.Input_Data.General_Data.txt_SearchUnit_Of_Measure.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varUnit_of_Measure' with focus on 'ApplicationUnderTest.Input_Data.General_Data.txt_SearchUnit_Of_Measure'.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_SearchUnit_Of_MeasureInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_SearchUnit_Of_Measure.PressKeys(varUnit_of_Measure);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.btn_Search_Action' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.btn_Search_ActionInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Input_Data.General_Data.btn_Search_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.lb_Select_Unit' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.lb_Select_UnitInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Input_Data.General_Data.lb_Select_Unit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Add_Laboratory' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Add_LaboratoryInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Add_Laboratory.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Search_Laboratory' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_LaboratoryInfo, new RecordItemIndex(7));
            //repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_Laboratory.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varLaboratory' with focus on 'ApplicationUnderTest.Input_Data.General_Data.txt_Search_Laboratory'.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_LaboratoryInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_Laboratory.PressKeys(varLaboratory);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.btn_Search_Laboratory_Action' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.btn_Search_Laboratory_ActionInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.Input_Data.General_Data.btn_Search_Laboratory_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.lb_Select_Laboratory' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.lb_Select_LaboratoryInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.Input_Data.General_Data.lb_Select_Laboratory.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Old_material_number' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Old_material_numberInfo, new RecordItemIndex(11));
            //repo.ApplicationUnderTest.Input_Data.General_Data.txt_Old_material_number.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varOld_material' with focus on 'ApplicationUnderTest.Input_Data.General_Data.txt_Old_material_number'.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Old_material_numberInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Old_material_number.PressKeys(varOld_material);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Page_Format' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Page_FormatInfo, new RecordItemIndex(13));
            //repo.ApplicationUnderTest.Input_Data.General_Data.txt_Page_Format.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varPage_Format' with focus on 'ApplicationUnderTest.Input_Data.General_Data.txt_Page_Format'.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Page_FormatInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Page_Format.PressKeys(varPage_Format);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Product_Hierarchy' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Product_HierarchyInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Product_Hierarchy.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Search_Product_Hierarchy' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_Product_HierarchyInfo, new RecordItemIndex(16));
            //repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_Product_Hierarchy.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varProduct_Hierarchy' with focus on 'ApplicationUnderTest.Input_Data.General_Data.txt_Search_Product_Hierarchy'.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_Product_HierarchyInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_Product_Hierarchy.PressKeys(varProduct_Hierarchy);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.btn_Product_Hierarchy_Action' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.btn_Product_Hierarchy_ActionInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.Input_Data.General_Data.btn_Product_Hierarchy_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.lb_Select_Product_Hierarchy' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.lb_Select_Product_HierarchyInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.Input_Data.General_Data.lb_Select_Product_Hierarchy.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Length' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_LengthInfo, new RecordItemIndex(20));
            //repo.ApplicationUnderTest.Input_Data.General_Data.txt_Length.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varLength' with focus on 'ApplicationUnderTest.Input_Data.General_Data.txt_Length'.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_LengthInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Length.PressKeys(varLength);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Width' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_WidthInfo, new RecordItemIndex(22));
            //repo.ApplicationUnderTest.Input_Data.General_Data.txt_Width.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varWidth' with focus on 'ApplicationUnderTest.Input_Data.General_Data.txt_Width'.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_WidthInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Width.PressKeys(varWidth);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Height' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_HeightInfo, new RecordItemIndex(24));
            //repo.ApplicationUnderTest.Input_Data.General_Data.txt_Height.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varHeight' with focus on 'ApplicationUnderTest.Input_Data.General_Data.txt_Height'.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_HeightInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Height.PressKeys(varHeight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Unit' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_UnitInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Unit.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Search_Unit' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_UnitInfo, new RecordItemIndex(27));
            //repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_Unit.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varUnit' with focus on 'ApplicationUnderTest.Input_Data.General_Data.txt_Search_Unit'.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_UnitInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_Unit.PressKeys(varUnit);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.btn_Search_Unit_Action' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.btn_Search_Unit_ActionInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.Input_Data.General_Data.btn_Search_Unit_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.lb_Select_Unit_New' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.lb_Select_Unit_NewInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.Input_Data.General_Data.lb_Select_Unit_New.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Page_Number' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Page_NumberInfo, new RecordItemIndex(31));
            //repo.ApplicationUnderTest.Input_Data.General_Data.txt_Page_Number.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varPage_Number' with focus on 'ApplicationUnderTest.Input_Data.General_Data.txt_Page_Number'.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Page_NumberInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Page_Number.PressKeys(varPage_Number);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_X_Plant' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_X_PlantInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_X_Plant.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Search_X_Plant' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_X_PlantInfo, new RecordItemIndex(34));
            //repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_X_Plant.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varX_Plant' with focus on 'ApplicationUnderTest.Input_Data.General_Data.txt_Search_X_Plant'.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_X_PlantInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_X_Plant.PressKeys(varX_Plant);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.btn_Search_X_Plant_Action' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.btn_Search_X_Plant_ActionInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.Input_Data.General_Data.btn_Search_X_Plant_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.lb_Select_X_Plant' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.lb_Select_X_PlantInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.Input_Data.General_Data.lb_Select_X_Plant.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Valid_from' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Valid_fromInfo, new RecordItemIndex(38));
            //repo.ApplicationUnderTest.Input_Data.General_Data.txt_Valid_from.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varValid_from' with focus on 'ApplicationUnderTest.Input_Data.General_Data.txt_Valid_from'.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Valid_fromInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Valid_from.PressKeys(varValid_from);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Packaging_Materials' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Packaging_MaterialsInfo, new RecordItemIndex(40));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Packaging_Materials.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.txt_Search_Packaging_Materials' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_Packaging_MaterialsInfo, new RecordItemIndex(41));
            //repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_Packaging_Materials.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varPackaging_Materials' with focus on 'ApplicationUnderTest.Input_Data.General_Data.txt_Search_Packaging_Materials'.", repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_Packaging_MaterialsInfo, new RecordItemIndex(42));
            repo.ApplicationUnderTest.Input_Data.General_Data.txt_Search_Packaging_Materials.PressKeys(varPackaging_Materials);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.btn_Search_Packaging_Materials_Action' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.btn_Search_Packaging_Materials_ActionInfo, new RecordItemIndex(43));
            repo.ApplicationUnderTest.Input_Data.General_Data.btn_Search_Packaging_Materials_Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Input_Data.General_Data.lb_Select_Packaging_Materials' at Center.", repo.ApplicationUnderTest.Input_Data.General_Data.lb_Select_Packaging_MaterialsInfo, new RecordItemIndex(44));
            repo.ApplicationUnderTest.Input_Data.General_Data.lb_Select_Packaging_Materials.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
