using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class NoSHOSWarningViewModel : Child<StationEmulatorViewModel>
{
    public NoSHOSWarningViewModel(StationEmulatorViewModel parent)
    {
        Parent = parent;
    }
}