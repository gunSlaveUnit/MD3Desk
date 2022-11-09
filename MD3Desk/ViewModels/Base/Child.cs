namespace MD3Desk.ViewModels.Base;

public class Child : ViewModel
{
    #region Properties

    #region Parent 
    
    private StationEmulatorViewModel _parent;
    
    public StationEmulatorViewModel Parent
    {
        get => _parent;
        set => Set(ref _parent, value);
    }
    
    #endregion

    #endregion
}