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

namespace mortfolioTestLibrary
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The addTask recording.
    /// </summary>
    [TestModule("9324759d-5f9b-4a40-948d-d891af82de31", ModuleType.Recording, 1)]
    public partial class addTask : ITestModule
    {
        /// <summary>
        /// Holds an instance of the mortfolioTestLibraryRepository repository.
        /// </summary>
        public static mortfolioTestLibraryRepository repo = mortfolioTestLibraryRepository.Instance;

        static addTask instance = new addTask();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public addTask()
        {
            taskType = "";
            taskName = "";
            taskDesc = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static addTask Instance
        {
            get { return instance; }
        }

#region Variables

        string _taskType;

        /// <summary>
        /// Gets or sets the value of variable taskType.
        /// </summary>
        [TestVariable("4b5d02c6-ff2a-499d-a03a-807781c501df")]
        public string taskType
        {
            get { return _taskType; }
            set { _taskType = value; }
        }

        string _taskName;

        /// <summary>
        /// Gets or sets the value of variable taskName.
        /// </summary>
        [TestVariable("85e4559f-2458-445e-8f53-a17195dc4bd0")]
        public string taskName
        {
            get { return _taskName; }
            set { _taskName = value; }
        }

        string _taskDesc;

        /// <summary>
        /// Gets or sets the value of variable taskDesc.
        /// </summary>
        [TestVariable("7c87168c-9964-4143-9c8b-114e8da1bfbb")]
        public string taskDesc
        {
            get { return _taskDesc; }
            set { _taskDesc = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginPage.PnlMainMainContentClbTSBtnAddSmallIte' at Center.", repo.LoginPage.PnlMainMainContentClbTSBtnAddSmallIteInfo, new RecordItemIndex(0));
            repo.LoginPage.PnlMainMainContentClbTSBtnAddSmallIte.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$taskType' with focus on 'LoginPage.PnlMainMainContentClbTSPpAddSmallItem'.", repo.LoginPage.PnlMainMainContentClbTSPpAddSmallItemInfo, new RecordItemIndex(1));
            repo.LoginPage.PnlMainMainContentClbTSPpAddSmallItem.PressKeys(taskType);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$taskName' with focus on 'LoginPage.PnlMainMainContentClbTSPpAddSmallItem2'.", repo.LoginPage.PnlMainMainContentClbTSPpAddSmallItem2Info, new RecordItemIndex(2));
            repo.LoginPage.PnlMainMainContentClbTSPpAddSmallItem2.PressKeys(taskName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$taskDesc' with focus on 'LoginPage.PnlMainMainContentClbTSPpAddSmallItem1'.", repo.LoginPage.PnlMainMainContentClbTSPpAddSmallItem1Info, new RecordItemIndex(3));
            repo.LoginPage.PnlMainMainContentClbTSPpAddSmallItem1.PressKeys(taskDesc);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginPage.PnlMainMainContentClbTSPpAddSmallItem3' at 37;22.", repo.LoginPage.PnlMainMainContentClbTSPpAddSmallItem3Info, new RecordItemIndex(4));
            repo.LoginPage.PnlMainMainContentClbTSPpAddSmallItem3.Click("37;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginPage.PnlMainMainContentClbTSGrdTimeSheetD' at 6;13.", repo.LoginPage.PnlMainMainContentClbTSGrdTimeSheetDInfo, new RecordItemIndex(5));
            repo.LoginPage.PnlMainMainContentClbTSGrdTimeSheetD.Click("6;13");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
