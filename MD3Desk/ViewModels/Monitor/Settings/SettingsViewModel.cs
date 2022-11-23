using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor.Settings;

public class SettingsViewModel : Child<StationEmulatorViewModel>
{
    public SettingsViewModel(StationEmulatorViewModel parent)
    {
        Parent = parent;
    }
}