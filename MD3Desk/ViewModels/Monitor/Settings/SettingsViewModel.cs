using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor.Settings;

public class SettingsViewModel : Child
{
    public SettingsViewModel(StationEmulatorViewModel parent)
    {
        Parent = parent;
    }
}