using System.Windows.Input;
using MD3Desk.Infrastructure.Commands.Base;
using MD3Desk.ViewModels.Base;
using MD3Desk.ViewModels.Monitor;
using MD3Desk.ViewModels.Monitor.Settings;

namespace MD3Desk.ViewModels;

public class StationEmulatorViewModel : ViewModel
{
    #region Properties

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
    
    #region CurrrentViewModel 
    
    private ViewModel _currentViewModel;
    
    public ViewModel CurrentViewModel
    {
        get => _currentViewModel;
        set => Set(ref _currentViewModel, value);
    }
    
    #endregion
    
    #endregion
    
    #region Commands
    
    #region NavigateMainMenuCommand
        
    private ICommand _navigateMainMenuCommand;
    public ICommand NavigateMainMenuCommand => _navigateMainMenuCommand
        ??= new RelayCommand(OnNavigateMainMenuCommandExecuted, CanNavigateMainMenuCommandExecute);

    private void OnNavigateMainMenuCommandExecuted(object parameter)
        => CurrentViewModel = MainMenuVm;
        
    private bool CanNavigateMainMenuCommandExecute(object parameter) => true;
        
    #endregion

    #region 2. NavigateMonitorCommand
        
    private ICommand _navigateMonitorCommand;
    public ICommand NavigateMonitorCommand => _navigateMonitorCommand
        ??= new RelayCommand(OnNavigateMonitorCommandExecuted, CanNavigateMonitorCommandExecute);

    private void OnNavigateMonitorCommandExecuted(object parameter)
    {
        CurrentViewModel = SHOSVm.IsConfigured ? MonitorVm : NoSHOSWarningVm;
    }
        
    private bool CanNavigateMonitorCommandExecute(object parameter) => true;
        
    #endregion
    
    #region 2*. NavigateMonitorCommandWithoutShosChecking
        
    private ICommand _navigateMonitorWithoutShosCheckingCommand;
    public ICommand NavigateMonitorWithoutShosCheckingCommand => _navigateMonitorWithoutShosCheckingCommand
        ??= new RelayCommand(OnNavigateMonitorWithoutShosCheckingCommandExecuted, CanNavigateMonitorWithoutShosCheckingCommandExecute);

    private void OnNavigateMonitorWithoutShosCheckingCommandExecuted(object parameter)
    {
        CurrentViewModel = MonitorVm;
    }
        
    private bool CanNavigateMonitorWithoutShosCheckingCommandExecute(object parameter) => true;
        
    #endregion
    
    #region 7. NavigateSettingsCommand
        
    private ICommand _navigateSettingsCommand;
    public ICommand NavigateSettingsCommand => _navigateSettingsCommand
        ??= new RelayCommand(OnNavigateSettingsCommandExecuted, CanNavigateSettingsCommandExecute);

    private void OnNavigateSettingsCommandExecuted(object parameter)
        => CurrentViewModel = SettingsVm;
        
    private bool CanNavigateSettingsCommandExecute(object parameter) => true;
        
    #endregion
    
    #region 7.1. NavigateCommonCommand
        
    private ICommand _navigateCommonCommand;
    public ICommand NavigateCommonCommand => _navigateCommonCommand
        ??= new RelayCommand(OnNavigateCommonCommandExecuted, CanNavigateCommonCommandExecute);

    private void OnNavigateCommonCommandExecuted(object parameter)
        => CurrentViewModel = CommonVm;
        
    private bool CanNavigateCommonCommandExecute(object parameter) => true;
        
    #endregion

    #endregion

    public StationEmulatorViewModel()
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