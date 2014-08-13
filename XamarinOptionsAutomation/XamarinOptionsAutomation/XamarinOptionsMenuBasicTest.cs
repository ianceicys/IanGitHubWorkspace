using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XamarinOptionsAutomation
{
    /// <summary>
    ///     Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class XamarinOptionsMenuBasicTest
    {
        private UIMap map;

        /// <summary>
        ///     Gets or sets the test context which provides
        ///     information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }


        public UIMap UIMap
        {
            get
            {
                if ((map == null))
                {
                    map = new UIMap();
                }

                return map;
            }
        }

        [TestCategory("Xamarin_3_3_47_0"),
         TestCategory("VisualStudio_2013"),
         TestCategory("OptionsMenu"),
         TestCategory("iOS"),
         DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\TestData2014.csv",
             "TestData2014#csv", DataAccessMethod.Sequential), DeploymentItem("TestData2014.csv"), TestMethod]
        public void Options_AppleSDKTextBox_TextEntryisEditable()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.

            UIMap.ACT_Click_Xamarin_Android_Settings_TreeViewLevel_2();
            UIMap.ACT_Click_Xamarin_iOS_Settings_TreeViewLevel_2();
            UIMap.ASSERT_iOS_SettingsScreen_IsLoadedAndVisible();
            UIMap.ASSERT_AppleSDK_TxtBox_ValueisEmpty();
            UIMap.ACT_Enter_SDKValue_inAppleSDK_TextBox(TestContext.DataRow["Apple_SDK"].ToString());
            UIMap.ASSERT_SDKValueEntered_Matches_ExpectedValue();
            UIMap.ARRANGE_Clear_AppleSDK_BlankValue();
            UIMap.Arrange_Click_OKButton_ToCloseOptionsScreen();
        }

        [TestCategory("Xamarin_3_3_47_0"),
         TestCategory("VisualStudio_2013"),
         TestCategory("OptionsMenu"),
         TestCategory("Android"),
         DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\TestData2014.csv",
             "TestData2014#csv", DataAccessMethod.Sequential), DeploymentItem("TestData2014.csv"), TestMethod]
        public void Options_ChangeAndroidSDKLocation_NewSDKLocation()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.

            UIMap.ACT_Click_Xamarin_Android_Settings_TreeViewLevel_2();
            UIMap.ACT_ChangeAndroidSDKLocation_NegativeTest(TestContext.DataRow["AndroidSDKLocation"].ToString());
        }

        #region Additional test attributes

        ////Launch Visual Studio and Check to Ensure that the latest stable version of Xamarin is installed
        [TestInitialize]
        public void MyTestInitialize()
        {
            UIMap.ARRANGE_Launch_VisualStudio2013();
            UIMap.ARRANGE_Click_ToolsMenu();
            UIMap.ARRANGE_Click_Tools_OptionsMenu();
            UIMap.ASSERT_OptionsMenu_IsLoadedAndVisible();
            UIMap.ASSERT_SearchOptions_IsLoadedAndVisible();
            UIMap.ACT_Enter_Xamarin_inTxtBox_SearchOptions();
            UIMap.ASSERT_Xamarin_Android_InstalledAndVisible();
            UIMap.ASSERT_Xamarin_iOS_InstalledAndVisible();
            UIMap.ACT_Click_TopLevelOption();
            UIMap.ACT_Click_Check_Latest_Xamarin_Installed_NoNewUpdatesRequired();
        }

        ////Use TestCleanup to run code after each test has run
        [TestCleanup]
        public void MyTestCleanup()
        {
        }

        #endregion
    }
}