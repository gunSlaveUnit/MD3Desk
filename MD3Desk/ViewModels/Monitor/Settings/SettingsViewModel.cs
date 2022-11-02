using System.Windows.Input;
using MD3Desk.Infrastructure.Commands.Base;
using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.Monitor;

public class SettingsViewModel : ViewModel
{
    private readonly MainViewModel _parent;

    #region Commands

    #region NavigateCommonCommand
        
    private ICommand _navigateCommonCommand;
    public ICommand NavigateCommonCommand => _navigateCommonCommand
        ??= new RelayCommand(OnNavigateCommonCommandExecuted, CanNavigateCommonCommandExecute);

    private void OnNavigateCommonCommandExecuted(object parameter)
        => _parent.CurrentViewModel = _parent.CommonVm;
        
    private bool CanNavigateCommonCommandExecute(object parameter) => true;
        
    #endregion

    #endregion

    public SettingsViewModel(MainViewModel parent)
    {
        _parent = parent;
    }
}