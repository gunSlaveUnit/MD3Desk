using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class MainMenuViewModel : Child
{
    public MainMenuViewModel(MainViewModel parent)
    {
        Parent = parent;
    }
}