using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class MonitorViewModel : Child
{
    public MonitorViewModel(StationEmulatorViewModel parent)
    {
        Parent = parent;
    }
}