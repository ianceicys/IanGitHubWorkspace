using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;


namespace XamarinOptionsAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class XamarinOptionsMenuBasicTest
    {
        public XamarinOptionsMenuBasicTest()
        {
        }

        [TestCategory("Xamarin_3_3_47_0"),
        TestCategory("VisualStudio_2013"),
        TestCategory("OptionsMenu"),
        TestCategory("iOS"),
        DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\TestData2014.csv", "TestData2014#csv", DataAccessMethod.Sequential), DeploymentItem("TestData2014.csv"), TestMethod]

        public void Options_AppleSDKTextBox_TextEntryisEditable()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.

            this.UIMap.ACT_Click_Xamarin_Android_Settings_TreeViewLevel_2();
            this.UIMap.ACT_Click_Xamarin_iOS_Settings_TreeViewLevel_2();
            this.UIMap.ASSERT_iOS_SettingsScreen_IsLoadedAndVisible();
            this.UIMap.ASSERT_AppleSDK_TxtBox_ValueisEmpty();
            this.UIMap.ACT_Enter_SDKValue_inAppleSDK_TextBox(TestContext.DataRow["Apple_SDK"].ToString());
            this.UIMap.ASSERT_SDKValueEntered_Matches_ExpectedValue();
            this.UIMap.ARRANGE_Clear_AppleSDK_BlankValue();
            this.UIMap.Arrange_Click_OKButton_ToCloseOptionsScreen();
        }

[TestCategory("Xamarin_3_3_47_0"),
TestCategory("VisualStudio_2013"),
TestCategory("OptionsMenu"),
TestCategory("Android"),
DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\TestData2014.csv", "TestData2014#csv", DataAccessMethod.Sequential), DeploymentItem("TestData2014.csv"), TestMethod]

        public void Options_ChangeAndroidSDKLocation_NewSDKLocation()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.

            this.UIMap.ACT_Click_Xamarin_Android_Settings_TreeViewLevel_2();
            this.UIMap.ACT_ChangeAndroidSDKLocation_NegativeTest(TestContext.DataRow["AndroidSDKLocation"].ToString());
        }


        #region Additional test attributes


        ////Launch Visual Studio and Check to Ensure that the latest stable version of Xamarin is installed
        [TestInitialize()]
        public void MyTestInitialize()
        {
           

            this.UIMap.ARRANGE_Launch_VisualStudio2013();
            this.UIMap.ARRANGE_Click_ToolsMenu();
            this.UIMap.ARRANGE_Click_Tools_OptionsMenu();
            this.UIMap.ASSERT_OptionsMenu_IsLoadedAndVisible();
            this.UIMap.ASSERT_SearchOptions_IsLoadedAndVisible();
            this.UIMap.ACT_Enter_Xamarin_inTxtBox_SearchOptions();
            this.UIMap.ASSERT_Xamarin_Android_InstalledAndVisible();
            this.UIMap.ASSERT_Xamarin_iOS_InstalledAndVisible();
            this.UIMap.ACT_Click_TopLevelOption();
            this.UIMap.ACT_Click_Check_Latest_Xamarin_Installed_NoNewUpdatesRequired();
        }

        ////Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {

        }

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
        

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
