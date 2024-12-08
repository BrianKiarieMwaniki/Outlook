using System.Collections.ObjectModel;

namespace Outlook.Business;

public class NavigationItem
{
    public string Caption { get; set; } = default!;
    public string NavigationPath { get; set; } = default!;

    public ObservableCollection<NavigationItem>? Items { get; set; }

    public NavigationItem()
    {
        Items = new ObservableCollection<NavigationItem>();
    }
}
