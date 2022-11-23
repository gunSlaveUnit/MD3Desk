using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.MainWindow;

public class AssemblyViewModel : Child<MainViewModel>
{
    public AssemblyViewModel (MainViewModel parent)
    {
        Parent = parent;
    }
}