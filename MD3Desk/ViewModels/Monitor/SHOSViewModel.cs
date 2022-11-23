using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class SHOSViewModel : Child<StationEmulatorViewModel>
{
    public readonly bool IsConfigured;

    public SHOSViewModel(StationEmulatorViewModel parent)
    {
        Parent = parent;
        IsConfigured = false;
    }
}