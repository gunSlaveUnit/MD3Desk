using System.Windows.Input;
using MD3Desk.Infrastructure.Commands.Base;
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
        set => Set(ref _currentViewModel, value);
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

    #region MainMenuViewModel

    private MainMenuViewModel _mainMenuViewModel;
    
    public MainMenuViewModel MainMenuVm
    {
        get => _mainMenuViewModel;
        private set => Set(ref _mainMenuViewModel, value);
    }

    #endregion
    
    #region NoSHOWarningViewModel

    private NoSHOSWarningViewModel _noSHOWarningViewModel;
    
    public NoSHOSWarningViewModel NoSHOSWarningVm
    {
        get => _noSHOWarningViewModel;
        private set => Set(ref _noSHOWarningViewModel, value);
    }

    #endregion
    
    #region MonitorViewModel

    private MonitorViewModel _monitorViewModel;
    
    public MonitorViewModel MonitorVm
    {
        get => _monitorViewModel;
        private set => Set(ref _monitorViewModel, value);
    }

    #endregion
    
    #endregion

    public MainViewModel()
    {
        StartVm = new StartViewModel(this);
        MainMenuVm = new MainMenuViewModel(this);
        NoSHOSWarningVm = new NoSHOSWarningViewModel(this);
        MonitorVm = new MonitorViewModel(this);
        CurrentViewModel = StartVm;
    }
}