using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class SHOSViewModel : Child
{
    public readonly bool IsConfigured;

    public SHOSViewModel(MainViewModel parent)
    {
        Parent = parent;
        IsConfigured = false;
    }
}