using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class MainMenuViewModel : Child<StationEmulatorViewModel>
{
    public MainMenuViewModel(StationEmulatorViewModel parent)
    {
        Parent = parent;
    }
}