using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class MonitorViewModel : ViewModel
{
    private readonly MainViewModel _parent;
    
    public MonitorViewModel(MainViewModel parent)
    {
        _parent = parent;
    }
}