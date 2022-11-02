using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class SHOSViewModel : ViewModel
{
    #region Properties

    private readonly MainViewModel _parent;
    
    public bool IsConfigured;

    #endregion

    public SHOSViewModel(MainViewModel parent)
    {
        _parent = parent;
        IsConfigured = false;
    }
}