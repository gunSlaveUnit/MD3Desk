using System.Windows.Input;
using MD3Desk.Infrastructure.Commands.Base;
using MD3Desk.ViewModels;

namespace MD3Desk.Infrastructure;

public class Navigator
{
    private MainViewModel _parent;

    #region Commands
    
    #region NavigateMainMenuCommand
        
    private ICommand _navigateMainMenuCommand;
    public ICommand NavigateMainMenuCommand => _navigateMainMenuCommand
        ??= new RelayCommand(OnNavigateMainMenuCommandExecuted, CanNavigateMainMenuCommandExecute);

    private void OnNavigateMainMenuCommandExecuted(object parameter)
        => _parent.CurrentViewModel = _parent.MainMenuVm;
        
    private bool CanNavigateMainMenuCommandExecute(object parameter) => true;
        
    #endregion

    #region 2. NavigateMonitorCommand
        
    private ICommand _navigateMonitorCommand;
    public ICommand NavigateMonitorCommand => _navigateMonitorCommand
        ??= new RelayCommand(OnNavigateMonitorCommandExecuted, CanNavigateMonitorCommandExecute);

    private void OnNavigateMonitorCommandExecuted(object parameter)
    {
        _parent.CurrentViewModel = _parent.SHOSVm.IsConfigured ? _parent.MonitorVm : _parent.NoSHOSWarningVm;
    }
        
    private bool CanNavigateMonitorCommandExecute(object parameter) => true;
        
    #endregion
    
    #region 7. NavigateSettingsCommand
        
    private ICommand _navigateSettingsCommand;
    public ICommand NavigateSettingsCommand => _navigateSettingsCommand
        ??= new RelayCommand(OnNavigateSettingsCommandExecuted, CanNavigateSettingsCommandExecute);

    private void OnNavigateSettingsCommandExecuted(object parameter)
        => _parent.CurrentViewModel = _parent.SettingsVm;
        
    private bool CanNavigateSettingsCommandExecute(object parameter) => true;
        
    #endregion
    
    #region 7.1. NavigateCommonCommand
        
    private ICommand _navigateCommonCommand;
    public ICommand NavigateCommonCommand => _navigateCommonCommand
        ??= new RelayCommand(OnNavigateCommonCommandExecuted, CanNavigateCommonCommandExecute);

    private void OnNavigateCommonCommandExecuted(object parameter)
        => _parent.CurrentViewModel = _parent.CommonVm;
        
    private bool CanNavigateCommonCommandExecute(object parameter) => true;
        
    #endregion

    #endregion
    
    public Navigator(MainViewModel parent)
    {
        _parent = parent;
    }
}