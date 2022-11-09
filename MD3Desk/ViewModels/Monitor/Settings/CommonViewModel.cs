using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor.Settings;

public class CommonViewModel : Child
{
    public CommonViewModel(StationEmulatorViewModel parent)
    {
        Parent = parent;
    }
}