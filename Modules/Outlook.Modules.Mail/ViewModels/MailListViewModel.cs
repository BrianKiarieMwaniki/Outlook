﻿using Prism.Mvvm;
using Prism.Navigation.Regions;

namespace Outlook.Modules.Mail.ViewModels;

public class MailListViewModel : BindableBase, INavigationAware
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

    public bool IsNavigationTarget(NavigationContext navigationContext)
    {
        return true;
    }

    public void OnNavigatedFrom(NavigationContext navigationContext)
    {
        
    }

    public void OnNavigatedTo(NavigationContext navigationContext)
    {
        Title = navigationContext.Parameters.GetValue<string>("id");
    }
}
