using System.Windows.Input;
using MD3Desk.Infrastructure.Commands.Base;
using MD3Desk.ViewModels.Base;
using MD3Desk.ViewModels.Monitor;
using MD3Desk.ViewModels.Monitor.Settings;

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
    
    #region SHOSViewModel

    private SHOSViewModel _shosViewModel;
    
    public SHOSViewModel SHOSVm
    {
        get => _shosViewModel;
        private set => Set(ref _shosViewModel, value);
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
    
    #region SettingsViewModel

    private SettingsViewModel _settingsViewModel;
    
    public SettingsViewModel SettingsVm
    {
        get => _settingsViewModel;
        private set => Set(ref _settingsViewModel, value);
    }
    
    #endregion
    
    #region CommonViewModel

    private CommonViewModel _commonViewModel;
    
    public CommonViewModel CommonVm
    {
        get => _commonViewModel;
        private set => Set(ref _commonViewModel, value);
    }
    
    #endregion
    
    #endregion

    public MainViewModel()
    {
        StartVm = new StartViewModel(this);
        MainMenuVm = new MainMenuViewModel(this);
        SHOSVm = new SHOSViewModel(this);
        NoSHOSWarningVm = new NoSHOSWarningViewModel(this);
        MonitorVm = new MonitorViewModel(this);
        SettingsVm = new SettingsViewModel(this);
        CommonVm = new CommonViewModel(this);
        
        CurrentViewModel = StartVm;
    }
}