//----------------------------------------------------------------------------------------
// patterns & practices - Smart Client Software Factory - Guidance Package
//
// This file was generated by this guidance package as part of the solution template
//
// For more information see: 
// ms-help://MS.VSCC.v80/MS.VSIPCC.v80/ms.scsf.2006jun/SCSF/html/03-210-Creating%20a%20Smart%20Client%20Solution.htm
//
// Latest version of this Guidance Package: http://go.microsoft.com/fwlink/?LinkId=62182
//----------------------------------------------------------------------------------------

namespace ACOT.Infrastructure.Interface.Constants
{
    /// <summary>
    /// Constants for event topic names.
    /// </summary>
    public class EventTopicNames
    {
        /// <summary>
        /// Event fired to tell the shell to update the status panel
        /// </summary>
        /// 
        public const string ModuleLoad = "event://ModuleLoad";

        public const string StatusUpdate = "StatusUpdate";
        
        public const string TitleUpdate = "TitleUpdate";

        public const string ToolClick = "event://ToolClick";

        public const string AcotExit = "event://AcotExit";
       
        public const string ReadOrgShow = "event://ReadOrgShow";

        //public const string AboutDlgLoad = "event://AboutBoxLoad";
        public const string AboutDlgShow = "event://AboutBoxShow";        

        public const string OrganizationChange = "event://OrganizationChange";

        public const string FontChange = "event://FontChange";

        public const string DesktopChange = "event://DesktopChange";

        public const string MenuTreeVisibleChange = "event://MenuTreeVisibleChange";

        //public const string SettingDlgLoad = "event://SettingsDlgLoad";
        public const string SettingDlgShow = "event://SettingsDlgShow";

        public const string MainMenuUpdate = "event://MainMenuUpdate";

        public const string MainMenuClick = "event://MainMenuClick";
        public const string MainMenuClickExecute = "event://MainMenuClickExecute";

        //public const string InfoViewLoad = "event://InfoViewLoad";
        public const string InfoViewShow = "event://InfoViewShow";

        public const string CheckAddressViewShow = "event://CheckAddressViewShow";

        public const string MainMenuKeyDown = "event://MainMenuKeyDown";
        public const string MainMenuKeyDownExecute = "event://MainMenuKeyDownExecute";

        public const string MenuTreeLoad = "event://MenuTreeLoad";
        public const string MenuTreeShow = "event://MenuTreeShow";
               
        //public const string Exchange1Cv8Load = "event://Exchange1Cv8Load";
        public const string Exchange1Cv8Show = "event://Exchange1Cv8Show";

        public const string ChkAddrModuleClose = "event://OnChkAddrModuleClose";
    }
}
