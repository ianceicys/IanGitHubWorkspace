namespace XamarinOptionsAutomation
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {

        /// <summary>
        /// EnterAppleSDKLocation - Use 'EnterAppleSDKLocationParams' to pass parameters into this method.
        /// </summary>
        public void EnterAppleSDKLocation()
        {
            #region Variable Declarations
            WinEdit uITxtXcodeHintEdit = this.UIOptionsWindow.UITxtXcodeHintWindow.UITxtXcodeHintEdit;
            uITxtXcodeHintEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Type '/TEST/TEST1/TestValue' in 'txtXcodeHint' text box
            uITxtXcodeHintEdit.Text = this.EnterAppleSDKLocationParams.UITxtXcodeHintEditText;
        }

        public virtual EnterAppleSDKLocationParams EnterAppleSDKLocationParams
        {
            get
            {
                if ((this.mEnterAppleSDKLocationParams == null))
                {
                    this.mEnterAppleSDKLocationParams = new EnterAppleSDKLocationParams();
                }
                return this.mEnterAppleSDKLocationParams;
            }
        }

        private EnterAppleSDKLocationParams mEnterAppleSDKLocationParams;

        /// <summary>
        /// EnterAppleSDKLocation_New - Use 'EnterAppleSDKLocation_NewParams' to pass parameters into this method.
        /// </summary>
        public void EnterAppleSDKLocation_New()
        {
            #region Variable Declarations
            WinEdit uITxtXcodeHintEdit1 = this.UIOptionsWindow.UITxtXcodeHintWindow.UITxtXcodeHintEdit1;
            uITxtXcodeHintEdit1.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Type 'TEST1234' in 'txtXcodeHint' text box
            uITxtXcodeHintEdit1.Text = this.EnterAppleSDKLocation_NewParams.UITxtXcodeHintEdit1Text;
        }

        public virtual EnterAppleSDKLocation_NewParams EnterAppleSDKLocation_NewParams
        {
            get
            {
                if ((this.mEnterAppleSDKLocation_NewParams == null))
                {
                    this.mEnterAppleSDKLocation_NewParams = new EnterAppleSDKLocation_NewParams();
                }
                return this.mEnterAppleSDKLocation_NewParams;
            }
        }

        private EnterAppleSDKLocation_NewParams mEnterAppleSDKLocation_NewParams;

        /// <summary>
        /// EnterValueinTextBox - Use 'EnterValueinTextBoxParams' to pass parameters into this method.
        /// </summary>
        public void ACT_Enter_SDKValue_inAppleSDK_TextBox(string sdkvalue)
        {
            #region Variable Declarations
            WinEdit uITxtXcodeHintEdit = this.UIOptionsWindow.UITxtXcodeHintWindow1.UITxtXcodeHintEdit;
            uITxtXcodeHintEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            Keyboard.SendKeys("{TAB}");
            Keyboard.SendKeys(sdkvalue);
        }

        public virtual EnterValueinTextBoxParams EnterValueinTextBoxParams
        {
            get
            {
                if ((this.mEnterValueinTextBoxParams == null))
                {
                    this.mEnterValueinTextBoxParams = new EnterValueinTextBoxParams();
                }
                return this.mEnterValueinTextBoxParams;
            }
        }

        private EnterValueinTextBoxParams mEnterValueinTextBoxParams;







        /// <summary>
        /// Apple SDK is empty
        /// </summary>
        public void ASSERT_AppleSDK_TxtBox_ValueisEmpty()
        {
            #region Variable Declarations
            WinEdit uITxtXcodeHintEdit = this.UIOptionsWindow.UITxtXcodeHintWindow.UITxtXcodeHintEdit;
            uITxtXcodeHintEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Verify that the 'Text' property of 'txtXcodeHint' text box equals ''

            Assert.AreEqual(this.ASSERT_AppleSDKisEmptyExpectedValues.UITxtXcodeHintEditText, uITxtXcodeHintEdit.Text, "Apple SDK contains value");
        }

        public virtual ASSERT_AppleSDKisEmptyExpectedValues ASSERT_AppleSDKisEmptyExpectedValues
        {
            get
            {
                if ((this.mASSERT_AppleSDKisEmptyExpectedValues == null))
                {
                    this.mASSERT_AppleSDKisEmptyExpectedValues = new ASSERT_AppleSDKisEmptyExpectedValues();
                }
                return this.mASSERT_AppleSDKisEmptyExpectedValues;
            }
        }

        private ASSERT_AppleSDKisEmptyExpectedValues mASSERT_AppleSDKisEmptyExpectedValues;

        /// <summary>
        /// Check if Mac Build Host is enabled.
        /// </summary>
        public void ASSERT_iOS_SettingsScreen_IsLoadedAndVisible()
        {
            #region Variable Declarations
            WinText uIMacBuildHostText = this.UIOptionsWindow.UIAndroidSDKLocationWindow.UIMacBuildHostText;
            uIMacBuildHostText.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Verify that the 'FriendlyName' property of 'Mac Build Host' label equals 'Mac Build Host'
            Assert.AreEqual(this.ASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues.UIMacBuildHostTextFriendlyName, uIMacBuildHostText.FriendlyName, "iOS Settings screen Not loaded successfully");
        }

        public virtual ASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues ASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues
        {
            get
            {
                if ((this.mASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues == null))
                {
                    this.mASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues = new ASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues();
                }
                return this.mASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues;
            }
        }

        private ASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues mASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues;

        /// <summary>
        /// ASSERT_ that the Options Menu has loaded
        /// </summary>
        public void ASSERT_OptionsMenu_IsLoadedAndVisible()
        {
            #region Variable Declarations
            WinTitleBar uIOptionsTitleBar = this.UIOptionsWindow.UIOptionsTitleBar;
            uIOptionsTitleBar.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Verify that the 'DisplayText' property of 'Options' title bar equals 'Options'
            Assert.AreEqual(this.ASSERT_OptionsMenuLoadedExpectedValues.UIOptionsTitleBarDisplayText, uIOptionsTitleBar.DisplayText, "Options Menu Not Loaded");
        }

        public virtual ASSERT_OptionsMenuLoadedExpectedValues ASSERT_OptionsMenuLoadedExpectedValues
        {
            get
            {
                if ((this.mASSERT_OptionsMenuLoadedExpectedValues == null))
                {
                    this.mASSERT_OptionsMenuLoadedExpectedValues = new ASSERT_OptionsMenuLoadedExpectedValues();
                }
                return this.mASSERT_OptionsMenuLoadedExpectedValues;
            }
        }

        private ASSERT_OptionsMenuLoadedExpectedValues mASSERT_OptionsMenuLoadedExpectedValues;

        /// <summary>
        /// ASSERT_SDKValueEntered - Use 'ASSERT_SDKValueEnteredExpectedValues' to pass parameters into this method.
        /// </summary>
        public void ASSERT_SDKValueEntered_Matches_ExpectedValue()
        {
            #region Variable Declarations
            WinEdit uITxtXcodeHintEdit = this.UIOptionsWindow.UITxtXcodeHintWindow1.UITxtXcodeHintEdit;
            uITxtXcodeHintEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Verify that the 'Text' property of 'txtXcodeHint' text box equals 'Test1234'
            Assert.AreEqual(this.ASSERT_SDKValueEnteredExpectedValues.UITxtXcodeHintEditText, uITxtXcodeHintEdit.Text, "Incorrect Value");
        }

        public virtual ASSERT_SDKValueEnteredExpectedValues ASSERT_SDKValueEnteredExpectedValues
        {
            get
            {
                if ((this.mASSERT_SDKValueEnteredExpectedValues == null))
                {
                    this.mASSERT_SDKValueEnteredExpectedValues = new ASSERT_SDKValueEnteredExpectedValues();
                }
                return this.mASSERT_SDKValueEnteredExpectedValues;
            }
        }

        private ASSERT_SDKValueEnteredExpectedValues mASSERT_SDKValueEnteredExpectedValues;

        /// <summary>
        /// ASSERT_ that the Search Options Text Box is Displayed
        /// </summary>
        public void ASSERT_SearchOptions_IsLoadedAndVisible()
        {
            #region Variable Declarations
            WpfEdit uISearchOptionsCtrlEdit = this.UIOptionsWindow.UIOptionsDialog.UIItemWindow.UISearchControlCustom.UISearchOptionsCtrlEdit;
            uISearchOptionsCtrlEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Verify that the 'FriendlyName' property of 'Search Options (Ctrl+E)' text box equals 'Search Options (Ctrl+E)'
            Assert.AreEqual(this.ASSERT_SearchOptionsDisplayedExpectedValues.UISearchOptionsCtrlEditFriendlyName, uISearchOptionsCtrlEdit.FriendlyName, "ASSERT_ Update atleast update 1 is installed");
        }

        public virtual ASSERT_SearchOptionsDisplayedExpectedValues ASSERT_SearchOptionsDisplayedExpectedValues
        {
            get
            {
                if ((this.mASSERT_SearchOptionsDisplayedExpectedValues == null))
                {
                    this.mASSERT_SearchOptionsDisplayedExpectedValues = new ASSERT_SearchOptionsDisplayedExpectedValues();
                }
                return this.mASSERT_SearchOptionsDisplayedExpectedValues;
            }
        }

        private ASSERT_SearchOptionsDisplayedExpectedValues mASSERT_SearchOptionsDisplayedExpectedValues;

        /// <summary>
        /// ASSERT_ Xamararin Android Installed
        /// </summary>
        public void ASSERT_Xamarin_Android_InstalledAndVisible()
        {
            #region Variable Declarations
            WinTreeItem uIAndroidSettingsTreeItem = this.UIOptionsWindow.UIItemWindow.UIXamarinTreeItem.UIAndroidSettingsTreeItem;
            uIAndroidSettingsTreeItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Verify that the 'Name' property of 'Xamarin' -> 'Android Settings' tree item equals 'Android Settings'
            Assert.AreEqual(this.ASSERT_XamarinAndroidInstalledExpectedValues.UIAndroidSettingsTreeItemName, uIAndroidSettingsTreeItem.Name, "Android Version Not Installed");
        }

        public virtual ASSERT_XamarinAndroidInstalledExpectedValues ASSERT_XamarinAndroidInstalledExpectedValues
        {
            get
            {
                if ((this.mASSERT_XamarinAndroidInstalledExpectedValues == null))
                {
                    this.mASSERT_XamarinAndroidInstalledExpectedValues = new ASSERT_XamarinAndroidInstalledExpectedValues();
                }
                return this.mASSERT_XamarinAndroidInstalledExpectedValues;
            }
        }

        private ASSERT_XamarinAndroidInstalledExpectedValues mASSERT_XamarinAndroidInstalledExpectedValues;

        /// <summary>
        /// ASSERT_ Xamarin iOS Installed
        /// </summary>
        public void ASSERT_Xamarin_iOS_InstalledAndVisible()
        {
            #region Variable Declarations
            WinTreeItem uIIOSSettingsTreeItem = this.UIOptionsWindow.UIItemWindow.UIXamarinTreeItem.UIIOSSettingsTreeItem;
            uIIOSSettingsTreeItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Verify that the 'Name' property of 'Xamarin' -> 'iOS Settings' tree item equals 'iOS Settings'
            Assert.AreEqual(this.ASSERT_XamariniOSInstalledExpectedValues.UIIOSSettingsTreeItemName, uIIOSSettingsTreeItem.Name, "Xamarin iOS Not Installed");
        }

        public virtual ASSERT_XamariniOSInstalledExpectedValues ASSERT_XamariniOSInstalledExpectedValues
        {
            get
            {
                if ((this.mASSERT_XamariniOSInstalledExpectedValues == null))
                {
                    this.mASSERT_XamariniOSInstalledExpectedValues = new ASSERT_XamariniOSInstalledExpectedValues();
                }
                return this.mASSERT_XamariniOSInstalledExpectedValues;
            }
        }

        private ASSERT_XamariniOSInstalledExpectedValues mASSERT_XamariniOSInstalledExpectedValues;

        /// <summary>
        /// ClickiOSCheckNow
        /// </summary>
        public void ACT_Click_Check_Latest_Xamarin_Installed_NoNewUpdatesRequired()
        {
            #region Variable Declarations
            WinHyperlink uICheckNowHyperlink = this.UIOptionsWindow.UICheckNowText.UICheckNowHyperlink;
            uICheckNowHyperlink.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            WinButton uIOKButton = this.UIOKWindow.UIOKButton;
            uIOKButton.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Click 'Check Now' link
            Mouse.Click(uICheckNowHyperlink, new Point(22, 11));

            // Set the playback to wait for all threads to finish
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.AllThreads;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(43, 13));

            // Reset the playback to wait only for the UI thread to finish
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.UIThreadOnly;

            Playback.Wait(2000);
        }

        /// <summary>
        /// Click the OK Button
        /// </summary>
        public void Arrange_Click_OKButton_ToCloseOptionsScreen()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UIOptionsWindow.UIOKWindow.UIOKButton;
            uIOKButton.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(59, 18));
        }

        /// <summary>
        /// Click the Tools Menu inside Visual Studio 2013
        /// </summary>
        public void ARRANGE_Click_ToolsMenu()
        {
            #region Variable Declarations
            WpfMenuItem uIToolsMenuItem = this.UIStartPageMicrosoftViWindow.UIMenuBarMenuBar.UIToolsMenuItem;
            uIToolsMenuItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Click 'Tools' menu item
            Mouse.Click(uIToolsMenuItem, new Point(21, 6));
        }

        /// <summary>
        /// Click the Tools Options Menu in Visual Studio 2013
        /// </summary>
        public void ARRANGE_Click_Tools_OptionsMenu()
        {
            #region Variable Declarations
            WpfMenuItem uIOptionsMenuItem = this.UIStartPageMicrosoftViWindow.UIMenuBarMenuBar.UIToolsMenuItem.UIOptionsMenuItem;
            uIOptionsMenuItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Click 'Tools' -> 'Options...' menu item
            Mouse.Click(uIOptionsMenuItem, new Point(104, 7));
        }

        /// <summary>
        /// ClickTxtBox
        /// </summary>
        public void ClickTxtBox()
        {
            #region Variable Declarations
            WinEdit uITxtXcodeHintEdit = this.UIOptionsWindow.UITxtXcodeHintWindow1.UITxtXcodeHintEdit;
            uITxtXcodeHintEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Click 'txtXcodeHint' text box
            Mouse.Click(uITxtXcodeHintEdit, new Point(33, 11));
        }

        /// <summary>
        /// Click on the TreeList Options Control
        /// </summary>
        public void ACT_Click_Xamarin_Android_Settings_TreeViewLevel_2()
        {
            #region Variable Declarations
            WinTreeItem uIAndroidSettingsTreeItem = this.UIOptionsWindow.UIItemWindow.UIXamarinTreeItem.UIAndroidSettingsTreeItem;
            uIAndroidSettingsTreeItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Click 'Xamarin' -> 'Android Settings' tree item
            Playback.Wait(2000);
            Mouse.Click(uIAndroidSettingsTreeItem, new Point(50, 7));
        }

        /// <summary>
        /// Click ios Settings Level
        /// </summary>
        public void ACT_Click_Xamarin_iOS_Settings_TreeViewLevel_2()
        {
            #region Variable Declarations
            WinTreeItem uIIOSSettingsTreeItem = this.UIOptionsWindow.UIItemWindow.UIXamarinTreeItem.UIIOSSettingsTreeItem;
            uIIOSSettingsTreeItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Click 'Xamarin' -> 'iOS Settings' tree item
            Playback.Wait(2000);
            Mouse.Click(uIIOSSettingsTreeItem, new Point(29, 7));
        }

        /// <summary>
        /// Top Level Xamarin Options
        /// </summary>
        public void ACT_Click_TopLevelOption()
        {
            #region Variable Declarations
            WinTreeItem uIXamarinTreeItem = this.UIOptionsWindow.UIItemWindow.UIXamarinTreeItem;
            uIXamarinTreeItem.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Click 'Xamarin' tree item
            Mouse.Click(uIXamarinTreeItem, new Point(28, 12));
        }

        /// <summary>
        /// Filter the Search Propoerties for Xamarin
        /// </summary>
        public void ACT_Enter_Xamarin_inTxtBox_SearchOptions()
        {
            #region Variable Declarations
            WpfEdit uISearchOptionsCtrlEdit = this.UIOptionsWindow.UIOptionsDialog.UIItemWindow.UISearchControlCustom.UISearchOptionsCtrlEdit;
            uISearchOptionsCtrlEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Type 'Xamarin' in 'Search Options (Ctrl+E)' text box
            uISearchOptionsCtrlEdit.Text = this.EnterXamarinSearchOptionsParams.UISearchOptionsCtrlEditText;
        }

        public virtual EnterXamarinSearchOptionsParams EnterXamarinSearchOptionsParams
        {
            get
            {
                if ((this.mEnterXamarinSearchOptionsParams == null))
                {
                    this.mEnterXamarinSearchOptionsParams = new EnterXamarinSearchOptionsParams();
                }
                return this.mEnterXamarinSearchOptionsParams;
            }
        }

        private EnterXamarinSearchOptionsParams mEnterXamarinSearchOptionsParams;

        /// <summary>
        /// Launch Visual Studio 2013 Application
        /// </summary>
        public void ARRANGE_Launch_VisualStudio2013()
        {

            // Launch '%ProgramFiles%\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe'
            ApplicationUnderTest devenvApplication = ApplicationUnderTest.Launch(this.LaunchVisualStudio2013Params.ExePath, this.LaunchVisualStudio2013Params.AlternateExePath);
        }

        public virtual LaunchVisualStudio2013Params LaunchVisualStudio2013Params
        {
            get
            {
                if ((this.mLaunchVisualStudio2013Params == null))
                {
                    this.mLaunchVisualStudio2013Params = new LaunchVisualStudio2013Params();
                }
                return this.mLaunchVisualStudio2013Params;
            }
        }

        private LaunchVisualStudio2013Params mLaunchVisualStudio2013Params;

        /// <summary>
        /// Clear out the value entered in the Apple SDK Field
        /// </summary>
        public void ARRANGE_Clear_AppleSDK_BlankValue()
        {
            #region Variable Declarations
            WinEdit uITxtXcodeHintEdit = this.UIOptionsWindow.UITxtXcodeHintWindow1.UITxtXcodeHintEdit;
            uITxtXcodeHintEdit.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            #endregion

            // Type '' in 'txtXcodeHint' text box
            Keyboard.SendKeys("{LEFT}{LEFT}{LEFT}{LEFT}{LEFT}{LEFT}{LEFT}{LEFT}{DEL}{DEL}{DEL}{DEL}{DEL}{DEL}{DEL}{DEL}");
        }

        public virtual ARRANGE_Clear_AppleSDK_BlankValueParams ARRANGE_Clear_AppleSDK_BlankValueParams
        {
            get
            {
                if ((this.mARRANGE_Clear_AppleSDK_BlankValueParams == null))
                {
                    this.mARRANGE_Clear_AppleSDK_BlankValueParams = new ARRANGE_Clear_AppleSDK_BlankValueParams();
                }
                return this.mARRANGE_Clear_AppleSDK_BlankValueParams;
            }
        }

        private ARRANGE_Clear_AppleSDK_BlankValueParams mARRANGE_Clear_AppleSDK_BlankValueParams;


        /// <summary>
        /// ACT_ChangeAndroidSDKLocation_NegativeTest - Use 'ACT_ChangeAndroidSDKLocation_NegativeTestParams' to pass parameters into this method.
        /// </summary>
        public void ACT_ChangeAndroidSDKLocation_NegativeTest(string newSDKLocation)
        {
            #region Variable Declarations
            WinHyperlink uIChangeHyperlink = this.UIOptionsWindow.UIChangeText.UIChangeHyperlink;
            WinEdit uITextBox1Edit = this.UISelectAndroidSDKWindow.UICUsersIanAppDataLocaWindow.UITextBox1Edit;
            WinButton uIOKButton = this.UISelectAndroidSDKWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIInvalidSDKWindow.UIOKWindow.UIOKButton;
            WinButton uICancelButton = this.UISelectAndroidSDKWindow.UICancelWindow.UICancelButton;
            WinButton uIOKButton2 = this.UIOptionsWindow.UIOKWindow.UIOKButton;
            #endregion

            // Click 'Change' link
            Mouse.Click(uIChangeHyperlink, new Point(18, 10));

            // Reset the playback to wait only for the UI thread to finish
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.UIThreadOnly;

            Keyboard.SendKeys("{TAB}{TAB}");

            // Set the playback to wait for all threads to finish
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.AllThreads;

            Keyboard.SendKeys("newSDKLocation");
            // Type 'TEST' in 'textBox1' text box
            //uITextBox1Edit.Text = this.ACT_ChangeAndroidSDKLocation_NegativeTestParams.UITextBox1EditText;



            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(46, 10));



            // Click '&OK' button
            Mouse.Click(uIOKButton1, new Point(43, 12));

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(45, 7));

            // Click 'OK' button
            Mouse.Click(uIOKButton2, new Point(16, 7));
        }

        public virtual ACT_ChangeAndroidSDKLocation_NegativeTestParams ACT_ChangeAndroidSDKLocation_NegativeTestParams
        {
            get
            {
                if ((this.mACT_ChangeAndroidSDKLocation_NegativeTestParams == null))
                {
                    this.mACT_ChangeAndroidSDKLocation_NegativeTestParams = new ACT_ChangeAndroidSDKLocation_NegativeTestParams();
                }
                return this.mACT_ChangeAndroidSDKLocation_NegativeTestParams;
            }
        }

        private ACT_ChangeAndroidSDKLocation_NegativeTestParams mACT_ChangeAndroidSDKLocation_NegativeTestParams;
    }
    /// <summary>
    /// Parameters to be passed into 'EnterAppleSDKLocation'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class EnterAppleSDKLocationParams
    {

        #region Fields
        /// <summary>
        /// Type '/TEST/TEST1/TestValue' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEditText = "/TEST/TEST1/TestValue";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'EnterAppleSDKLocation_New'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class EnterAppleSDKLocation_NewParams
    {

        #region Fields
        /// <summary>
        /// Type 'TEST1234' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEdit1Text = "TEST1234";
        #endregion
    }

    /// <summary>
    /// Parameters to be passed into 'EnterAppleSDKLocation_New'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ClearAppleSDKLocation_NewParams
    {

        #region Fields
        /// <summary>
        /// Type 'TEST1234' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEdit1Text = "TEST1234";
        #endregion
    }

    /// <summary>
    /// Parameters to be passed into 'EnterAppleSDKLocation_New'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ClearValueinTextBoxParams
    {

        #region Fields
        /// <summary>
        /// Type 'TEST1234' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEdit1Text = "TEST1234";
        #endregion
    }


    /// <summary>
    /// Parameters to be passed into 'EnterValueinTextBox'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class EnterValueinTextBoxParams
    {

        #region Fields
        /// <summary>
        /// Type 'tests' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEditText = "tests";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ASSERT_AppleSDKisEmpty'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_AppleSDKisEmptyExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'Text' property of 'txtXcodeHint' text box equals ''
        /// </summary>
        public string UITxtXcodeHintEditText = "";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ASSERT_iOSSettingsScreenLoadedSuccessfully'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_iOSSettingsScreenLoadedSuccessfullyExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'FriendlyName' property of 'Mac Build Host' label equals 'Mac Build Host'
        /// </summary>
        public string UIMacBuildHostTextFriendlyName = "Mac Build Host";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ASSERT_OptionsMenuLoaded'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_OptionsMenuLoadedExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of 'Options' title bar equals 'Options'
        /// </summary>
        public string UIOptionsTitleBarDisplayText = "Options";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ASSERT_SDKValueEntered'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_SDKValueEnteredExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'Text' property of 'txtXcodeHint' text box equals 'Test1234'
        /// </summary>
        public string UITxtXcodeHintEditText = "Test1234";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ASSERT_SearchOptionsDisplayed'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_SearchOptionsDisplayedExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'FriendlyName' property of 'Search Options (Ctrl+E)' text box equals 'Search Options (Ctrl+E)'
        /// </summary>
        public string UISearchOptionsCtrlEditFriendlyName = "Search Options (Ctrl+E)";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ASSERT_XamarinAndroidInstalled'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_XamarinAndroidInstalledExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Xamarin' -> 'Android Settings' tree item equals 'Android Settings'
        /// </summary>
        public string UIAndroidSettingsTreeItemName = "Android Settings";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ASSERT_XamariniOSInstalled'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ASSERT_XamariniOSInstalledExpectedValues
    {

        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Xamarin' -> 'iOS Settings' tree item equals 'iOS Settings'
        /// </summary>
        public string UIIOSSettingsTreeItemName = "iOS Settings";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'EnterBlankinAppleSDK'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class EnterBlankinAppleSDKParams
    {

        #region Fields
        /// <summary>
        /// Type '' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEditText = "";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'EnterXamarinSearchOptions'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class EnterXamarinSearchOptionsParams
    {

        #region Fields
        /// <summary>
        /// Type 'Xamarin' in 'Search Options (Ctrl+E)' text box
        /// </summary>
        public string UISearchOptionsCtrlEditText = "Xamarin";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'LaunchVisualStudio2013'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class LaunchVisualStudio2013Params
    {

        #region Fields
        /// <summary>
        /// Launch '%ProgramFiles%\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe'
        /// </summary>
        public string ExePath = "C:\\Program Files (x86)\\Microsoft Visual Studio 12.0\\Common7\\IDE\\devenv.exe";

        /// <summary>
        /// Launch '%ProgramFiles%\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe'
        /// </summary>
        public string AlternateExePath = "%ProgramFiles%\\Microsoft Visual Studio 12.0\\Common7\\IDE\\devenv.exe";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ARRANGE_Clear_AppleSDK_BlankValue'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ARRANGE_Clear_AppleSDK_BlankValueParams
    {

        #region Fields
        /// <summary>
        /// Type '' in 'txtXcodeHint' text box
        /// </summary>
        public string UITxtXcodeHintEditText = "";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'ACT_ChangeAndroidSDKLocation_NegativeTest'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class ACT_ChangeAndroidSDKLocation_NegativeTestParams
    {

        #region Fields
        /// <summary>
        /// Type 'TEST' in 'textBox1' text box
        /// </summary>
        public string UITextBox1EditText = "TEST";
        #endregion
}
}
