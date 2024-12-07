using Infragistics.Windows.Ribbon;
using Infragistics.Themes;
using System.Windows;

namespace Outlook.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : XamRibbonWindow
{
    public MainWindow()
    {
        InitializeComponent();

        ThemeManager.ApplicationTheme = new Office2013Theme();
    }
}
