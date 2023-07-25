﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace EDF__PRD_MM01.Admin
{
    public partial class Scheduled_Requests_ON
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Set_Scheduled_Request_ON(RepoItemInfo inputtagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IsActive.", inputtagInfo);
            Report.Log(ReportLevel.Info, "IsActive", inputtagInfo.FindAdapter<DivTag>().FindChild<DivTag>().Visible.ToString(), inputtagInfo);
            
            var bl_Mass_Action_Process_Status = repo.SimpleMDG_Admin.Core_Settings.bl_Mass_Action_Process_Status;
        	
            if(inputtagInfo.FindAdapter<DivTag>().FindChild<DivTag>().Visible.ToString() == "False")
            {
            	bl_Mass_Action_Process_Status.Click();	
            }
        }

    }
}
