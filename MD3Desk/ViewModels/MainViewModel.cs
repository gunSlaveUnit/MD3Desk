using MD3Desk.ViewModels.Base;
using MD3Desk.ViewModels.Monitor;

namespace MD3Desk.ViewModels;

public class MainViewModel : ViewModel
{
    #region Properties 
    
    #region CurrrentViewModel 
    
    private ViewModel _currentViewModel;
    
    public ViewModel CurrentViewModel
    {
        get => _currentViewModel;
        private set => Set(ref _currentViewModel, value);
    }
    
    #endregion
    
    #region StartViewModel
    
    private StartViewModel _startViewModel;
    
    public StartViewModel StartVm
    {
        get => _startViewModel;
        private set => Set(ref _startViewModel, value);
    }
    
    #endregion
    
    #endregion

    public MainViewModel()
    {
        StartVm = new StartViewModel();
        CurrentViewModel = StartVm;
    }
}