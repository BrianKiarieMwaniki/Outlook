using Outlook.Core;
using Outlook.Modules.Mail.Menus;
using Outlook.Modules.Mail.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Outlook.Modules.Mail
{
    public class MailModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MailModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            //TODO: remove
            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(ViewA));
            _regionManager.RegisterViewWithRegion(RegionNames.RibbonRegion, typeof(HomeTab));
            _regionManager.RegisterViewWithRegion(RegionNames.OutlookGroupRegion, typeof(MailGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}