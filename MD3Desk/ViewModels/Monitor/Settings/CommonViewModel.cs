using System.Windows.Input;
using MD3Desk.Infrastructure.Commands.Base;
using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor.Settings;

public class CommonViewModel : ViewModel
{
    private readonly MainViewModel _parent;

    #region Commands

    #region NavigateMainMenuCommand
        
    private ICommand _navigateSettingsCommand;
    public ICommand NavigateSettingsCommand => _navigateSettingsCommand
        ??= new RelayCommand(OnNavigateSettingsCommandExecuted, CanNavigateSettingsCommandExecute);

    private void OnNavigateSettingsCommandExecuted(object parameter)
        => _parent.CurrentViewModel = _parent.SettingsVm;
        
    private bool CanNavigateSettingsCommandExecute(object parameter) => true;
        
    #endregion

    #endregion

    public CommonViewModel(MainViewModel parent)
    {
        _parent = parent;
    }
}