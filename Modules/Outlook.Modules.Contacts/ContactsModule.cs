using Outlook.Core;
using Outlook.Modules.Contacts.Menus;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Outlook.Modules.Contacts
{
    public class ContactsModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ContactsModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.OutlookGroupRegion, typeof(ContactsGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}