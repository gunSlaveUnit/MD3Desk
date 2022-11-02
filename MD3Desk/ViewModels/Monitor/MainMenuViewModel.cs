using System.Windows.Input;
using MD3Desk.Infrastructure.Commands.Base;
using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class MainMenuViewModel : ViewModel
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
        => _parent.CurrentViewModel = _parent.NoSHOSWarningVm;
        
    private bool CanNavigateMonitorCommandExecute(object parameter) => true;
        
    #endregion
    
    #endregion
    
    public MainMenuViewModel(MainViewModel parent)
    {
        _parent = parent;
    }
}