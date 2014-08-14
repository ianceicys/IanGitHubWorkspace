using System.CodeDom.Compiler;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XamarinOptionsAutomation
{
    public partial class UIMap
    {
        private ACT_ChangeAndroidSDKLocation_NegativeTestParams _mActChangeAndroidSdkLocationNegativeTestParams;
        private ARRANGE_Clear_AppleSDK_BlankValueParams _mArrangeClearAppleSdkBlankValueParams;
        private ASSERT_AppleSDKisEmptyExpectedValues _mAssertAppleSdKisEmptyExpectedValues;
        private ASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues _mAssertIOsSettingsScreenLoadedSuccessfullyExpectedValues;
        private ASSERT_OptionsMenuLoadedExpectedValues _mAssertOptionsMenuLoadedExpectedValues;
        private ASSERT_SDKValueEnteredExpectedValues _mAssertSdkValueEnteredExpectedValues;
        private ASSERT_SearchOptionsDisplayedExpectedValues _mAssertSearchOptionsDisplayedExpectedValues;
        private ASSERT_XamarinAndroidInstalledExpectedValues _mAssertXamarinAndroidInstalledExpectedValues;
        private ASSERT_XamariniOSInstalledExpectedValues _mAssertXamariniOsInstalledExpectedValues;
        private EnterAppleSDKLocation_NewParams _mEnterAppleSdkLocationNewParams;
        private EnterAppleSDKLocationParams _mEnterAppleSdkLocationParams;
        private EnterValueinTextBoxParams _mEnterValueinTextBoxParams;
        private EnterXamarinSearchOptionsParams _mEnterXamarinSearchOptionsParams;
        private LaunchVisualStudio2013Params _mLaunchVisualStudio2013Params;
        private ARRANGE_ClickExpand_XamarinOption_VS2010Params _mArrangeClickExpandXamarinOptionVs2010Params;
        private ASSERT_OptionsMenuLoaded_VS2010ExpectedValues _mAssertOptionsMenuLoadedVs2010ExpectedValues;

        public virtual EnterAppleSDKLocationParams EnterAppleSDKLocationParams
        {
            get
            {
                if ((_mEnterAppleSdkLocationParams == null))
                {
                    _mEnterAppleSdkLocationParams = new EnterAppleSDKLocationParams();
                }
                return _mEnterAppleSdkLocationParams;
            }
        }

        public virtual EnterAppleSDKLocation_NewParams EnterAppleSDKLocation_NewParams
        {
            get
            {
                if ((_mEnterAppleSdkLocationNewParams == null))
                {
                    _mEnterAppleSdkLocationNewParams = new EnterAppleSDKLocation_NewParams();
                }
                return _mEnterAppleSdkLocationNewParams;
            }
        }

        public virtual EnterValueinTextBoxParams EnterValueinTextBoxParams
        {
            get
            {
                if ((_mEnterValueinTextBoxParams == null))
                {
                    _mEnterValueinTextBoxParams = new EnterValueinTextBoxParams();
                }
                return _mEnterValueinTextBoxParams;
            }
        }


        public virtual ASSERT_AppleSDKisEmptyExpectedValues ASSERT_AppleSDKisEmptyExpectedValues
        {
            get
            {
                if ((_mAssertAppleSdKisEmptyExpectedValues == null))
                {
                    _mAssertAppleSdKisEmptyExpectedValues = new ASSERT_AppleSDKisEmptyExpectedValues();
                }
                return _mAssertAppleSdKisEmptyExpectedValues;
            }
        }

        public virtual ASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues
            ASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues
        {
            get
            {
                if ((_mAssertIOsSettingsScreenLoadedSuccessfullyExpectedValues == null))
                {
                    _mAssertIOsSettingsScreenLoadedSuccessfullyExpectedValues =
                        new ASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues();
                }
                return _mAssertIOsSettingsScreenLoadedSuccessfullyExpectedValues;
            }
        }

        public virtual ASSERT_OptionsMenuLoadedExpectedValues ASSERT_OptionsMenuLoadedExpectedValues
        {
            get
            {
                if ((_mAssertOptionsMenuLoadedExpectedValues == null))
                {
                    _mAssertOptionsMenuLoadedExpectedValues = new ASSERT_OptionsMenuLoadedExpectedValues();
                }
                return _mAssertOptionsMenuLoadedExpectedValues;
            }
        }

        public virtual ASSERT_SDKValueEnteredExpectedValues ASSERT_SDKValueEnteredExpectedValues
        {
            get
            {
                if ((_mAssertSdkValueEnteredExpectedValues == null))
                {
                    _mAssertSdkValueEnteredExpectedValues = new ASSERT_SDKValueEnteredExpectedValues();
                }
                return _mAssertSdkValueEnteredExpectedValues;
            }
        }

        public virtual ASSERT_SearchOptionsDisplayedExpectedValues ASSERT_SearchOptionsDisplayedExpectedValues
        {
            get
            {
                if ((_mAssertSearchOptionsDisplayedExpectedValues == null))
                {
                    _mAssertSearchOptionsDisplayedExpectedValues = new ASSERT_SearchOptionsDisplayedExpectedValues();
                }
                return _mAssertSearchOptionsDisplayedExpectedValues;
            }
        }

        public virtual ASSERT_XamarinAndroidInstalledExpectedValues ASSERT_XamarinAndroidInstalledExpectedValues
        {
            get
            {
                if ((_mAssertXamarinAndroidInstalledExpectedValues == null))
                {
                    _mAssertXamarinAndroidInstalledExpectedValues = new ASSERT_XamarinAndroidInstalledExpectedValues();
                }
                return _mAssertXamarinAndroidInstalledExpectedValues;
            }
        }

        public virtual ASSERT_XamariniOSInstalledExpectedValues ASSERT_XamariniOSInstalledExpectedValues
        {
            get
            {
                if ((_mAssertXamariniOsInstalledExpectedValues == null))
                {
                    _mAssertXamariniOsInstalledExpectedValues = new ASSERT_XamariniOSInstalledExpectedValues();
                }
                return _mAssertXamariniOsInstalledExpectedValues;
            }
        }

        public virtual EnterXamarinSearchOptionsParams EnterXamarinSearchOptionsParams
        {
            get
            {
                if ((_mEnterXamarinSearchOptionsParams == null))
                {
                    _mEnterXamarinSearchOptionsParams = new EnterXamarinSearchOptionsParams();
                }
                return _mEnterXamarinSearchOptionsParams;
            }
        }

        public virtual LaunchVisualStudio2013Params LaunchVisualStudio2013Params
        {
            get
            {
                if ((_mLaunchVisualStudio2013Params == null))
                {
                    _mLaunchVisualStudio2013Params = new LaunchVisualStudio2013Params();
                }
                return _mLaunchVisualStudio2013Params;
            }
        }

        public virtual ARRANGE_Clear_AppleSDK_BlankValueParams ARRANGE_Clear_AppleSDK_BlankValueParams
        {
            get
            {
                if ((_mArrangeClearAppleSdkBlankValueParams == null))
                {
                    _mArrangeClearAppleSdkBlankValueParams = new ARRANGE_Clear_AppleSDK_BlankValueParams();
                }
                return _mArrangeClearAppleSdkBlankValueParams;
            }
        }

        public virtual ACT_ChangeAndroidSDKLocation_NegativeTestParams ACT_ChangeAndroidSDKLocation_NegativeTestParams
        {
            get
            {
                if ((_mActChangeAndroidSdkLocationNegativeTestParams == null))
                {
                    _mActChangeAndroidSdkLocationNegativeTestParams =
                        new ACT_ChangeAndroidSDKLocation_NegativeTestParams();
                }
                return _mActChangeAndroidSdkLocationNegativeTestParams;
            }
        }

        public virtual ARRANGE_ClickExpand_XamarinOption_VS2010Params ARRANGE_ClickExpand_XamarinOption_VS2010Params
        {
            get
            {
                if ((_mArrangeClickExpandXamarinOptionVs2010Params == null))
                {
                    _mArrangeClickExpandXamarinOptionVs2010Params =
                        new ARRANGE_ClickExpand_XamarinOption_VS2010Params();
                }
                return _mArrangeClickExpandXamarinOptionVs2010Params;
            }
        }

        public virtual ASSERT_OptionsMenuLoaded_VS2010ExpectedValues ASSERT_OptionsMenuLoaded_VS2010ExpectedValues
        {
            get
            {
                if ((_mAssertOptionsMenuLoadedVs2010ExpectedValues == null))
                {
                    _mAssertOptionsMenuLoadedVs2010ExpectedValues = new ASSERT_OptionsMenuLoaded_VS2010ExpectedValues();
                }
                return _mAssertOptionsMenuLoadedVs2010ExpectedValues;
            }
        }


        /// <summary>
        ///     EnterValueinTextBox - Use 'EnterValueinTextBoxParams' to pass parameters into this method.
        /// </summary>
        public void ACT_Enter_SDKValue_inAppleSDK_TextBox(string sdkvalue)
        {
            #region Variable Declarations

            WinEdit uITxtXcodeHintEdit = UIOptionsWindow.UITxtXcodeHintWindow1.UITxtXcodeHintEdit;
            uITxtXcodeHintEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            Keyboard.SendKeys(sdkvalue);
        }

        /// <summary>
        ///     Apple SDK is empty
        /// </summary>
        public void ASSERT_AppleSDK_TxtBox_ValueisEmpty()
        {
            #region Variable Declarations

            WinEdit uITxtXcodeHintEdit = UIOptionsWindow.UITxtXcodeHintWindow.UITxtXcodeHintEdit;
            uITxtXcodeHintEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Verify that the 'Text' property of 'txtXcodeHint' text box equals ''
            Keyboard.SendKeys("{TAB}");

            Assert.AreEqual(ASSERT_AppleSDKisEmptyExpectedValues.UITxtXcodeHintEditText, uITxtXcodeHintEdit.Text,
                "Apple SDK contains value");
        }

        /// <summary>
        ///     Check if Mac Build Host is enabled.
        /// </summary>
        public void ASSERT_iOS_SettingsScreen_IsLoadedAndVisible()
        {
            #region Variable Declarations

            WinText uIMacBuildHostText = UIOptionsWindow.UIAndroidSDKLocationWindow.UIMacBuildHostText;
            uIMacBuildHostText.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Verify that the 'FriendlyName' property of 'Mac Build Host' label equals 'Mac Build Host'
            Assert.AreEqual(ASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues.UIMacBuildHostTextFriendlyName,
                uIMacBuildHostText.FriendlyName, "iOS Settings screen Not loaded successfully");
        }

        /// <summary>
        ///     ASSERT_ that the Options Menu has loaded
        /// </summary>
        public void ASSERT_OptionsMenu_IsLoadedAndVisible()
        {
            #region Variable Declarations

            WinTitleBar uIOptionsTitleBar = UIOptionsWindow.UIOptionsTitleBar;
            uIOptionsTitleBar.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Verify that the 'DisplayText' property of 'Options' title bar equals 'Options'
            Assert.AreEqual(ASSERT_OptionsMenuLoadedExpectedValues.UIOptionsTitleBarDisplayText,
                uIOptionsTitleBar.DisplayText, "Options Menu Not Loaded");
        }

        /// <summary>
        ///     ASSERT_SDKValueEntered - Use 'ASSERT_SDKValueEnteredExpectedValues' to pass parameters into this method.
        /// </summary>
        public void ASSERT_SDKValueEntered_Matches_ExpectedValue()
        {
            #region Variable Declarations

            WinEdit uITxtXcodeHintEdit = UIOptionsWindow.UITxtXcodeHintWindow1.UITxtXcodeHintEdit;
            uITxtXcodeHintEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Verify that the 'Text' property of 'txtXcodeHint' text box equals 'Test1234'
            Assert.AreEqual(ASSERT_SDKValueEnteredExpectedValues.UITxtXcodeHintEditText, uITxtXcodeHintEdit.Text,
                "Incorrect Value");
        }

        /// <summary>
        ///     ASSERT_ that the Search Options Text Box is Displayed
        /// </summary>
        public void ASSERT_SearchOptions_IsLoadedAndVisible()
        {
            #region Variable Declarations

            WpfEdit uISearchOptionsCtrlEdit =
                UIOptionsWindow.UIOptionsDialog.UIItemWindow.UISearchControlCustom.UISearchOptionsCtrlEdit;
            uISearchOptionsCtrlEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Verify that the 'FriendlyName' property of 'Search Options (Ctrl+E)' text box equals 'Search Options (Ctrl+E)'
            Assert.AreEqual(ASSERT_SearchOptionsDisplayedExpectedValues.UISearchOptionsCtrlEditFriendlyName,
                uISearchOptionsCtrlEdit.FriendlyName, "ASSERT_ Update atleast update 1 is installed");
        }

        /// <summary>
        ///     ASSERT_ Xamararin Android Installed
        /// </summary>
        public void ASSERT_Xamarin_Android_InstalledAndVisible()
        {
            #region Variable Declarations

            WinTreeItem uIAndroidSettingsTreeItem =
                UIOptionsWindow.UIItemWindow.UIXamarinTreeItem.UIAndroidSettingsTreeItem;
            uIAndroidSettingsTreeItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Verify that the 'Name' property of 'Xamarin' -> 'Android Settings' tree item equals 'Android Settings'
            Assert.AreEqual(ASSERT_XamarinAndroidInstalledExpectedValues.UIAndroidSettingsTreeItemName,
                uIAndroidSettingsTreeItem.Name, "Android Version Not Installed");
        }

        /// <summary>
        ///     ASSERT_ Xamarin iOS Installed
        /// </summary>
        public void ASSERT_Xamarin_iOS_InstalledAndVisible()
        {
            #region Variable Declarations

            WinTreeItem uIIOSSettingsTreeItem = UIOptionsWindow.UIItemWindow.UIXamarinTreeItem.UIIOSSettingsTreeItem;
            uIIOSSettingsTreeItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Verify that the 'Name' property of 'Xamarin' -> 'iOS Settings' tree item equals 'iOS Settings'
            Assert.AreEqual(ASSERT_XamariniOSInstalledExpectedValues.UIIOSSettingsTreeItemName,
                uIIOSSettingsTreeItem.Name, "Xamarin iOS Not Installed");
        }

        /// <summary>
        ///     ClickiOSCheckNow
        /// </summary>
        public void ACT_Click_Check_Latest_Xamarin_Installed_NoNewUpdatesRequired()
        {
            #region Variable Declarations

            WinHyperlink uICheckNowHyperlink = UIOptionsWindow.UICheckNowText.UICheckNowHyperlink;
            uICheckNowHyperlink.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            WinButton uIOKButton = UIOKWindow.UIOKButton;
            uIOKButton.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Click 'Check Now' link
            Mouse.Click(uICheckNowHyperlink, new Point(22, 11));

            // Click 'OK' button
            Keyboard.SendKeys(" ");
        }

        /// <summary>
        ///     Click the OK Button
        /// </summary>
        public void Arrange_Click_OKButton_ToCloseOptionsScreen()
        {
            #region Variable Declarations

            WinButton uIOKButton = UIOptionsWindow.UIOKWindow.UIOKButton;
            uIOKButton.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(59, 18));
        }

        /// <summary>
        ///     Click the Tools Menu inside Visual Studio 2013
        /// </summary>
        public void ARRANGE_Click_ToolsMenu()
        {
            #region Variable Declarations

            WpfMenuItem uIToolsMenuItem = UIStartPageMicrosoftViWindow.UIMenuBarMenuBar.UIToolsMenuItem;
            uIToolsMenuItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Click 'Tools' menu item
            Mouse.Click(uIToolsMenuItem, new Point(21, 6));
        }

        /// <summary>
        ///     Click the Tools Options Menu in Visual Studio 2013
        /// </summary>
        public void ARRANGE_Click_Tools_OptionsMenu()
        {
            #region Variable Declarations

            WpfMenuItem uIOptionsMenuItem =
                UIStartPageMicrosoftViWindow.UIMenuBarMenuBar.UIToolsMenuItem.UIOptionsMenuItem;
            uIOptionsMenuItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Click 'Tools' -> 'Options...' menu item
            Mouse.Click(uIOptionsMenuItem, new Point(104, 7));
        }

        /// <summary>
        ///     ClickTxtBox
        /// </summary>
        public void ClickTxtBox()
        {
            #region Variable Declarations

            WinEdit uITxtXcodeHintEdit = UIOptionsWindow.UITxtXcodeHintWindow1.UITxtXcodeHintEdit;
            uITxtXcodeHintEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Click 'txtXcodeHint' text box
            Mouse.Click(uITxtXcodeHintEdit, new Point(33, 11));
        }

        /// <summary>
        ///     Click on the TreeList Options Control
        /// </summary>
        public void ACT_Click_Xamarin_Android_Settings_TreeViewLevel_2()
        {
            #region Variable Declarations

            WinTreeItem uIAndroidSettingsTreeItem =
                UIOptionsWindow.UIItemWindow.UIXamarinTreeItem.UIAndroidSettingsTreeItem;
            uIAndroidSettingsTreeItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Click 'Xamarin' -> 'Android Settings' tree item
            Playback.Wait(2000);
            Mouse.Click(uIAndroidSettingsTreeItem, new Point(50, 7));
        }

        /// <summary>
        ///     Click ios Settings Level
        /// </summary>
        public void ACT_Click_Xamarin_iOS_Settings_TreeViewLevel_2()
        {
            #region Variable Declarations

            WinTreeItem uIIOSSettingsTreeItem = UIOptionsWindow.UIItemWindow.UIXamarinTreeItem.UIIOSSettingsTreeItem;
            uIIOSSettingsTreeItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Click 'Xamarin' -> 'iOS Settings' tree item
            Playback.Wait(2000);
            Mouse.Click(uIIOSSettingsTreeItem, new Point(29, 7));
        }

        /// <summary>
        ///     Top Level Xamarin Options
        /// </summary>
        public void ACT_Click_TopLevelOption()
        {
            #region Variable Declarations

            WinTreeItem uIXamarinTreeItem = UIOptionsWindow.UIItemWindow.UIXamarinTreeItem;
            uIXamarinTreeItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Click 'Xamarin' tree item
            Mouse.Click(uIXamarinTreeItem, new Point(28, 12));
        }

        /// <summary>
        ///     Filter the Search Propoerties for Xamarin
        /// </summary>
        public void ACT_Enter_Xamarin_inTxtBox_SearchOptions()
        {
            #region Variable Declarations

            WpfEdit uISearchOptionsCtrlEdit =
                UIOptionsWindow.UIOptionsDialog.UIItemWindow.UISearchControlCustom.UISearchOptionsCtrlEdit;
            uISearchOptionsCtrlEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);

            #endregion

            // Type 'Xamarin' in 'Search Options (Ctrl+E)' text box
            uISearchOptionsCtrlEdit.Text = EnterXamarinSearchOptionsParams.UISearchOptionsCtrlEditText;
        }

        /// <summary>
        ///     Launch Visual Studio 2013 Application
        /// </summary>
        public void ARRANGE_Launch_VisualStudio2013()
        {
            // Launch '%ProgramFiles%\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe'
            ApplicationUnderTest devenvApplication = ApplicationUnderTest.Launch(LaunchVisualStudio2013Params.ExePath,
                LaunchVisualStudio2013Params.AlternateExePath);
        }


        /// <summary>
        ///     ACT_ChangeAndroidSDKLocation_NegativeTest - Use 'ACT_ChangeAndroidSDKLocation_NegativeTestParams' to pass
        ///     parameters into this method.
        /// </summary>
        public void ACT_ChangeAndroidSDKLocation_NegativeTest(string newSDKLocation)
        {
            #region Variable Declarations

            WinHyperlink uIChangeHyperlink = UIOptionsWindow.UIChangeText.UIChangeHyperlink;
            WinEdit uITextBox1Edit = UISelectAndroidSDKWindow.UICUsersIanAppDataLocaWindow.UITextBox1Edit;
            WinButton uIOKButton = UISelectAndroidSDKWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = UIInvalidSDKWindow.UIOKWindow.UIOKButton;
            WinButton uICancelButton = UISelectAndroidSDKWindow.UICancelWindow.UICancelButton;
            WinButton uIOKButton2 = UIOptionsWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click 'Change' link
            Mouse.Click(uIChangeHyperlink, new Point(18, 10));

            // Reset the playback to wait only for the UI thread to finish
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.UIThreadOnly;

            Keyboard.SendKeys("{TAB}{TAB}");

            // Set the playback to wait for all threads to finish
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.AllThreads;

            Keyboard.SendKeys(newSDKLocation);
            // Type 'TEST' in 'textBox1' text box
            //uITextBox1Edit.Text = this.ACT_ChangeAndroidSDKLocation_NegativeTestParams.UITextBox1EditText;

            Playback.PlaybackSettings.MatchExactHierarchy = true;
            // Click 'OK' button
            Keyboard.SendKeys("{ENTER}");
            //Mouse.Click(uIOKButton, new Point(46, 10));

            // Click '&OK' button
            Keyboard.SendKeys("{ENTER}");
            // Mouse.Click(uIOKButton1, new Point(43, 12));

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(45, 7));

            // Click 'OK' button
            Keyboard.SendKeys("{ENTER}");
            //Mouse.Click(uIOKButton2, new Point(16, 7));
        }

        /// <summary>
        ///     Click Tools Options in Visual Studio 2010
        /// </summary>
        public void ARRANGE_Click_ToolsOptions_VS2010()
        {
            #region Variable Declarations

            WpfMenuItem uIOptionsMenuItem =
                UIStartPageMicrosoftViWindow.UIMenuBarMenuBar.UIToolsMenuItem.UIOptionsMenuItem;

            #endregion

            // Click 'Tools' -> 'Options...' menu item
            Mouse.Click(uIOptionsMenuItem, new Point(107, 16));
        }

        /// <summary>
        ///     Click and Expand the Visual Studio 2010 Xamarin Menu
        /// </summary>
        public void ARRANGE_ClickExpand_XamarinOption_VS2010()
        {
            #region Variable Declarations

            WinTreeItem uIXamarinTreeItem = UIOptionsWindow.UIItemWindow.UIXamarinTreeItem;

            #endregion

            Keyboard.SendKeys("{LEFT}{LEFT}");

            // Click 'Xamarin' tree item
            Mouse.Click(uIXamarinTreeItem, new Point(31, 11));

            // Expand 'Xamarin' tree item
            uIXamarinTreeItem.Expanded = ARRANGE_ClickExpand_XamarinOption_VS2010Params.UIXamarinTreeItemExpanded;
        }

        /// <summary>
        ///     Assert Options Menu Loaded
        /// </summary>
        public void ASSERT_OptionsMenuLoaded_VS2010()
        {
            #region Variable Declarations

            WinTitleBar uIOptionsTitleBar = UIOptionsWindow.UIOptionsTitleBar;

            #endregion

            // Verify that the 'DisplayText' property of 'Options' title bar equals 'Options'
            Assert.AreEqual(ASSERT_OptionsMenuLoaded_VS2010ExpectedValues.UIOptionsTitleBarDisplayText,
                uIOptionsTitleBar.DisplayText, "OptionsMenu is not loaded successfully");
        }
    }

    /// <summary>
    ///     Parameters to be passed into 'EnterAppleSDKLocation'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class EnterAppleSDKLocationParams
    {
        #region Fields

        /// <summary>
        ///     Type '/TEST/TEST1/TestValue' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEditText = "/TEST/TEST1/TestValue";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'EnterAppleSDKLocation_New'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class EnterAppleSDKLocation_NewParams
    {
        #region Fields

        /// <summary>
        ///     Type 'TEST1234' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEdit1Text = "TEST1234";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'EnterAppleSDKLocation_New'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ClearAppleSDKLocation_NewParams
    {
        #region Fields

        /// <summary>
        ///     Type 'TEST1234' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEdit1Text = "TEST1234";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'EnterAppleSDKLocation_New'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ClearValueinTextBoxParams
    {
        #region Fields

        /// <summary>
        ///     Type 'TEST1234' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEdit1Text = "TEST1234";

        #endregion
    }


    /// <summary>
    ///     Parameters to be passed into 'EnterValueinTextBox'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class EnterValueinTextBoxParams
    {
        #region Fields

        /// <summary>
        ///     Type 'tests' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEditText = "tests";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'ASSERT_AppleSDKisEmpty'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_AppleSDKisEmptyExpectedValues
    {
        #region Fields

        /// <summary>
        ///     Verify that the 'Text' property of 'txtXcodeHint' text box equals ''
        /// </summary>
        public string UITxtXcodeHintEditText = "";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'ASSERT_iOSSettingsScreenLoadedSuccessfully'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues
    {
        #region Fields

        /// <summary>
        ///     Verify that the 'FriendlyName' property of 'Mac Build Host' label equals 'Mac Build Host'
        /// </summary>
        public string UIMacBuildHostTextFriendlyName = "Mac Build Host";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'ASSERT_OptionsMenuLoaded'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_OptionsMenuLoadedExpectedValues
    {
        #region Fields

        /// <summary>
        ///     Verify that the 'DisplayText' property of 'Options' title bar equals 'Options'
        /// </summary>
        public string UIOptionsTitleBarDisplayText = "Options";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'ASSERT_SDKValueEntered'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_SDKValueEnteredExpectedValues
    {
        #region Fields

        /// <summary>
        ///     Verify that the 'Text' property of 'txtXcodeHint' text box equals 'Test1234'
        /// </summary>
        public string UITxtXcodeHintEditText = "Test1234";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'ASSERT_SearchOptionsDisplayed'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_SearchOptionsDisplayedExpectedValues
    {
        #region Fields

        /// <summary>
        ///     Verify that the 'FriendlyName' property of 'Search Options (Ctrl+E)' text box equals 'Search Options (Ctrl+E)'
        /// </summary>
        public string UISearchOptionsCtrlEditFriendlyName = "Search Options (Ctrl+E)";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'ASSERT_XamarinAndroidInstalled'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_XamarinAndroidInstalledExpectedValues
    {
        #region Fields

        /// <summary>
        ///     Verify that the 'Name' property of 'Xamarin' -> 'Android Settings' tree item equals 'Android Settings'
        /// </summary>
        public string UIAndroidSettingsTreeItemName = "Android Settings";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'ASSERT_XamariniOSInstalled'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_XamariniOSInstalledExpectedValues
    {
        #region Fields

        /// <summary>
        ///     Verify that the 'Name' property of 'Xamarin' -> 'iOS Settings' tree item equals 'iOS Settings'
        /// </summary>
        public string UIIOSSettingsTreeItemName = "iOS Settings";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'EnterBlankinAppleSDK'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class EnterBlankinAppleSDKParams
    {
        #region Fields

        /// <summary>
        ///     Type '' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEditText = "";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'EnterXamarinSearchOptions'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class EnterXamarinSearchOptionsParams
    {
        #region Fields

        /// <summary>
        ///     Type 'Xamarin' in 'Search Options (Ctrl+E)' text box
        /// </summary>
        public string UISearchOptionsCtrlEditText = "Xamarin";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'LaunchVisualStudio2013'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class LaunchVisualStudio2013Params
    {
        #region Fields

        /// <summary>
        ///     Launch '%ProgramFiles%\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe'
        /// </summary>
        public string AlternateExePath = "%ProgramFiles%\\Microsoft Visual Studio 12.0\\Common7\\IDE\\devenv.exe";

        /// <summary>
        ///     Launch '%ProgramFiles%\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe'
        /// </summary>
        public string ExePath = "C:\\Program Files (x86)\\Microsoft Visual Studio 12.0\\Common7\\IDE\\devenv.exe";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'ARRANGE_Clear_AppleSDK_BlankValue'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ARRANGE_Clear_AppleSDK_BlankValueParams
    {
        #region Fields

        /// <summary>
        ///     Type '' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEditText = "";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'ACT_ChangeAndroidSDKLocation_NegativeTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ACT_ChangeAndroidSDKLocation_NegativeTestParams
    {
        #region Fields

        /// <summary>
        ///     Type 'TEST' in 'textBox1' text box
        /// </summary>
        public string UITextBox1EditText = "TEST";

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'ARRANGE_ClickExpand_XamarinOption_VS2010'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ARRANGE_ClickExpand_XamarinOption_VS2010Params
    {
        #region Fields

        /// <summary>
        ///     Expand 'Xamarin' tree item
        /// </summary>
        public bool UIXamarinTreeItemExpanded = true;

        #endregion
    }

    /// <summary>
    ///     Parameters to be passed into 'ASSERT_OptionsMenuLoaded_VS2010'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_OptionsMenuLoaded_VS2010ExpectedValues
    {
        #region Fields

        /// <summary>
        ///     Verify that the 'DisplayText' property of 'Options' title bar equals 'Options'
        /// </summary>
        public string UIOptionsTitleBarDisplayText = "Options";

        #endregion
    }
}