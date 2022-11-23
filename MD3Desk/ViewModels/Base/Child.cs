namespace MD3Desk.ViewModels.Base;

public class Child<T> : ViewModel
{
    #region Properties

    #region Parent 
    
    private T _parent;
    
    public T Parent
    {
        get => _parent;
        set => Set(ref _parent, value);
    }
    
    #endregion

    #endregion
}