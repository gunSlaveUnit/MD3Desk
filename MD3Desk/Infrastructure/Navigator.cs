using System.Windows.Input;
using MD3Desk.Infrastructure.Commands.Base;
using MD3Desk.ViewModels;

namespace MD3Desk.Infrastructure;

public class Navigator
{
    private MainViewModel _parent;

    #region Commands

    #region NavigateMonitorCommand
        
    private ICommand _navigateMonitorCommand;
    public ICommand NavigateMonitorCommand => _navigateMonitorCommand
        ??= new RelayCommand(OnNavigateMonitorCommandExecuted, CanNavigateMonitorCommandExecute);

    private void OnNavigateMonitorCommandExecuted(object parameter)
        => _parent.CurrentViewModel = _parent.SHOSVm.IsConfigured ? _parent.MonitorVm : _parent.NoSHOSWarningVm;
        
    private bool CanNavigateMonitorCommandExecute(object parameter) => true;
        
    #endregion

    #endregion
    
    public Navigator(MainViewModel parent)
    {
        _parent = parent;
    }
}