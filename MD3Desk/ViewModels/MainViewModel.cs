using System.Windows.Input;
using MD3Desk.Infrastructure.Commands.Base;
using MD3Desk.ViewModels.Base;
using MD3Desk.ViewModels.Monitor;

namespace MD3Desk.ViewModels;

public class MainViewModel : ViewModel
{
    #region Properties 
    
    #region CurrrentViewModel 
    
    private ViewModel _currentViewModel;
    
    public ViewModel CurrentViewModel
    {
        get => _currentViewModel;
        private set => Set(ref _currentViewModel, value);
    }
    
    #endregion
    
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
    
    #endregion

    #region Commands

    #region ChangeCurrentViewCommand
        
    private ICommand _changeCurrentView;
    public ICommand ChangeCurrentViewCommand => _changeCurrentView
        ??= new RelayCommand(OnChangeCurrentViewCommandExecuted, CanChangeCurrentViewCommandExecute);

    private void OnChangeCurrentViewCommandExecuted(object parameter)
        => CurrentViewModel = (ViewModel) parameter;
        
    private bool CanChangeCurrentViewCommandExecute(object parameter) => true;
        
    #endregion

    #endregion

    public MainViewModel()
    {
        StartVm = new StartViewModel();
        MainMenuVm = new MainMenuViewModel();
        CurrentViewModel = StartVm;
    }
}