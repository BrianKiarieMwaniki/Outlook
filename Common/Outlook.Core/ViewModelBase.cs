namespace Outlook.Core;

public class ViewModelBase : BindableBase, IConfirmNavigationRequest
{
    public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
    {
        continuationCallback(true);
    }

    public bool IsNavigationTarget(NavigationContext navigationContext)
    {
        return true;
    }

    public virtual void OnNavigatedFrom(NavigationContext navigationContext)
    {
    }

    public virtual void OnNavigatedTo(NavigationContext navigationContext)
    {
    }
}
