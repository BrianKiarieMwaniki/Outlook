using Infragistics.Windows.OutlookBar;
using Infragistics.Windows.Ribbon;
using Outlook.Common.Regions;
using Outlook.Modules.Calendar;
using Outlook.Modules.Contacts;
using Outlook.Modules.Mail;
using Outlook.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;

namespace Outlook
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<MailModule>();
            moduleCatalog.AddModule<ContactsModule>();
            moduleCatalog.AddModule<CalendarModule>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);

            regionAdapterMappings.RegisterMapping(typeof(XamOutlookBar), Container.Resolve<OutlookGroupRegionAdapter>());
            regionAdapterMappings.RegisterMapping(typeof(XamRibbon), Container.Resolve<XamRibbonRegionAdapter>());
        }
    }
}
