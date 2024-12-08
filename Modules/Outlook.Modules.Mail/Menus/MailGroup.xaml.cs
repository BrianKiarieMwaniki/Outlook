using Infragistics.Controls.Menus;
using Infragistics.Windows.OutlookBar;
using Outlook.Business;
using Outlook.Core;

namespace Outlook.Modules.Mail.Menus;

/// <summary>
/// Interaction logic for MailGroup.xaml
/// </summary>
public partial class MailGroup : OutlookBarGroup, IOutlookBarGroup
{
    public MailGroup()
    {
        InitializeComponent();
    }

    public string DefaultNavigationPath
    {
        get
        {
            var item = _dataTree.SelectionSettings.SelectedNodes[0] as XamDataTreeNode;

            if (item != null)
            {
                return ((NavigationItem)item.Data).NavigationPath;
            }
            return "MailList";
        }
    }
}
