using Outlook.Core;
using Outlook.Modules.Contacts.Menus;
using System.Windows.Controls;

namespace Outlook.Modules.Contacts.Views
{
    /// <summary>
    /// Interaction logic for ViewA
    /// </summary>
    [DependentView(RegionNames.RibbonRegion, typeof(HomeTab))]
    public partial class ViewA : UserControl
    {
        public ViewA()
        {
            InitializeComponent();
        }
    }
}
