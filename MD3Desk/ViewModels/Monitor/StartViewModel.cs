using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class StartViewModel : Child
{
    public StartViewModel(StationEmulatorViewModel parent)
    {
        Parent = parent;
    }
}