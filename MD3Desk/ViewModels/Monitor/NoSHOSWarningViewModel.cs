using System.Windows.Input;
using MD3Desk.Infrastructure.Commands.Base;
using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class NoSHOSWarningViewModel : ViewModel
{
    #region Properties
    
    private readonly MainViewModel _parent;
    
    #endregion
    
    #region Commands

    #region NavigateMonitorCommand
        
    private ICommand _navigateMonitorCommand;
    
    public ICommand NavigateMonitorCommand => _navigateMonitorCommand
        ??= new RelayCommand(OnNavigateMonitorCommandExecuted, CanNavigateMonitorCommandExecute);

    private void OnNavigateMonitorCommandExecuted(object parameter)
        => _parent.CurrentViewModel = _parent.MonitorVm;
        
    private bool CanNavigateMonitorCommandExecute(object parameter) => true;
        
    #endregion
    
    #region NavigateMainMenuCommand
        
    private ICommand _navigateMainMenuCommand;
    public ICommand NavigateMainMenuCommand => _navigateMainMenuCommand
        ??= new RelayCommand(OnNavigateMainMenuCommandExecuted, CanNavigateMainMenuCommandExecute);

    private void OnNavigateMainMenuCommandExecuted(object parameter)
        => _parent.CurrentViewModel = _parent.MainMenuVm;
        
    private bool CanNavigateMainMenuCommandExecute(object parameter) => true;
        
    #endregion

    #endregion
    
    public NoSHOSWarningViewModel(MainViewModel parent)
    {
        _parent = parent;
    }
}