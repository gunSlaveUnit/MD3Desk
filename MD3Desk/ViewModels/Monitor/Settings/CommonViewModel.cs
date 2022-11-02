using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor.Settings;

public class CommonViewModel : ViewModel
{
    private readonly MainViewModel _parent;

    public CommonViewModel(MainViewModel parent)
    {
        _parent = parent;
    }
}