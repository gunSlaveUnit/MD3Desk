using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.MainWindow;

public class MainProgramMenuViewModel : Child<MainViewModel>
{
    public MainProgramMenuViewModel (MainViewModel parent)
    {
        Parent = parent;
    }
}