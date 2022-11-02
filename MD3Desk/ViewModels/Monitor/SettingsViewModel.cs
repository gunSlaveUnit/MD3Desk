using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class SettingsViewModel : ViewModel
{
    private readonly MainViewModel _parent;

    public SettingsViewModel(MainViewModel parent)
    {
        _parent = parent;
    }
}