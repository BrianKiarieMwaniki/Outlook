using Infragistics.Windows.Ribbon;
using Infragistics.Themes;
using System.Windows;
using Infragistics.Windows.OutlookBar;
using Outlook.Core;
using Prism.Navigation.Regions;

namespace Outlook.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : XamRibbonWindow
{
    private readonly IApplicationCommands _applicationCommands;

    public MainWindow(IApplicationCommands applicationCommands)
    {
        InitializeComponent();

        ThemeManager.ApplicationTheme = new Office2013Theme();
        _applicationCommands = applicationCommands;
    }

    private void XamOutlookBar_SelectedGroupChanged(object sender, RoutedEventArgs e)
    {
        var group = ((XamOutlookBar)sender).SelectedGroup as IOutlookBarGroup;

        if (group != null)
        {
            //TODO navigate to group.DefaultNavigationPath
            _applicationCommands.NavigateCommand.Execute(group.DefaultNavigationPath);
        }
    }
}
