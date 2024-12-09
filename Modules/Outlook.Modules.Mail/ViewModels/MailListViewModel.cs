using Outlook.Core;
using Prism.Mvvm;
using Prism.Navigation.Regions;

namespace Outlook.Modules.Mail.ViewModels;

public class MailListViewModel : ViewModelBase
{
    private string _title = "Default";

    public string Title
    {
        get { return _title ; }
        set { SetProperty(ref _title, value); }
    }

    public MailListViewModel()
    {

    }  

    public override void OnNavigatedTo(NavigationContext navigationContext)
    {
        Title = navigationContext.Parameters.GetValue<string>("id");
    }
}
