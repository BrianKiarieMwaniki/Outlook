using Outlook.Business;
using Outlook.Core;
using Prism.Commands;
using System.Collections.ObjectModel;

namespace Outlook.Modules.Mail.ViewModels;

public class MailGroupViewModel : ViewModelBase
{

    private ObservableCollection<NavigationItem> _items;

    public ObservableCollection<NavigationItem> Items
    {
        get { return _items; }
        set { SetProperty(ref _items, value); }
    }

    private DelegateCommand<NavigationItem> _selectedCommmand;
    private readonly IApplicationCommands _applicationCommands;

    public DelegateCommand<NavigationItem> SelectedCommand =>
        _selectedCommmand ?? (_selectedCommmand = new DelegateCommand<NavigationItem>(ExecuteSelectedCommand));
   

    public MailGroupViewModel(IApplicationCommands applicationCommands)
    {
        GenerateMenu();
        _applicationCommands = applicationCommands;
    }

    private void ExecuteSelectedCommand(NavigationItem navigationItem)
    {
        if (navigationItem != null)
            _applicationCommands.NavigateCommand.Execute(navigationItem.NavigationPath);
    }

    private void GenerateMenu()
    {
        Items = new ObservableCollection<NavigationItem>();

        var root = new NavigationItem() { Caption = "Personal Folder", NavigationPath = "MailList?id=Default" };
        root.Items.Add(new NavigationItem { Caption = "Inbox", NavigationPath = "MailList?id=Inbox" });
        root.Items.Add(new NavigationItem { Caption = "Deleted", NavigationPath = "MailList?id=Deleted" });
        root.Items.Add(new NavigationItem { Caption = "Sent", NavigationPath = "MailList?id=Sent" });

        Items.Add(root);
    }
}
