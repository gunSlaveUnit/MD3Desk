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

    #region NavigateSHOSCommand
        
    private ICommand _navigateSHOSCommand;
    public ICommand NavigateSHOSCommand => _navigateSHOSCommand
        ??= new RelayCommand(OnNavigateSHOSCommandExecuted, CanNavigateSHOSCommandExecute);

    private void OnNavigateSHOSCommandExecuted(object parameter)
        => _parent.CurrentViewModel = _parent.NoSHOSWarningVm;
        
    private bool CanNavigateSHOSCommandExecute(object parameter) => true;
        
    #endregion

    #endregion
    
    public MainMenuViewModel(MainViewModel parent)
    {
        _parent = parent;
    }
}