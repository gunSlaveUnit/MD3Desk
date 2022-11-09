using System.Windows.Input;
using MD3Desk.Infrastructure.Commands.Base;
using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class MainMenuViewModel : Child
{
    #region Commands

    #region NavigateSettingsCommand
        
    private ICommand _navigateSettingsCommand;
    public ICommand NavigateSettingsCommand => _navigateSettingsCommand
        ??= new RelayCommand(OnNavigateSettingsCommandExecuted, CanNavigateSettingsCommandExecute);

    private void OnNavigateSettingsCommandExecuted(object parameter)
        => Parent.CurrentViewModel = Parent.SettingsVm;
        
    private bool CanNavigateSettingsCommandExecute(object parameter) => true;
        
    #endregion
    
    #endregion
    
    public MainMenuViewModel(MainViewModel parent)
    {
        Parent = parent;
    }
}