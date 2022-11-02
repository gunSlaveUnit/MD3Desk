using System.Windows.Input;
using MD3Desk.Infrastructure.Commands.Base;
using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class StartViewModel : ViewModel
{
    #region Properties

    private MainViewModel _parent;
    
    #endregion

    #region Commands

    #region NavigateMainMenuCommand
        
    private ICommand _navigateMainMenuCommand;
    public ICommand NavigateMainMenuCommand => _navigateMainMenuCommand
        ??= new RelayCommand(OnNavigateMainMenuCommandExecuted, CanNavigateMainMenuCommandExecute);

    private void OnNavigateMainMenuCommandExecuted(object parameter)
        => _parent.CurrentViewModel = _parent.MainMenuVm;
        
    private bool CanNavigateMainMenuCommandExecute(object parameter) => true;
        
    #endregion

    #endregion
    
    public StartViewModel(MainViewModel parent)
    {
        _parent = parent;
    }
}