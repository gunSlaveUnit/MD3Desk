using System.Windows.Input;
using MD3Desk.Infrastructure.Commands.Base;
using MD3Desk.ViewModels.Base;
using MD3Desk.ViewModels.MainWindow;
using MD3Desk.Views.Windows;

namespace MD3Desk.ViewModels;

public class MainViewModel : ViewModel
{
    #region Properties

    #region StationEmulatorWindow 
    
    private StationEmulatorWindow _stationEmulatorWindow;
    
    public StationEmulatorWindow StationEmulatorWindow
    {
        get => _stationEmulatorWindow;
        set => Set(ref _stationEmulatorWindow, value);
    }
    
    #endregion
    
    #region MainMenuProgramViewModel

    private MainProgramMenuViewModel _mainProgramMenuViewModel;
    
    public MainProgramMenuViewModel MainProgramMenuVm
    {
        get => _mainProgramMenuViewModel;
        private set => Set(ref _mainProgramMenuViewModel, value);
    }

    #endregion
    
    #region CurrrentViewModel 
    
    private ViewModel _currentViewModel;
    
    public ViewModel CurrentViewModel
    {
        get => _currentViewModel;
        set => Set(ref _currentViewModel, value);
    }
    
    #endregion

    #endregion
    
    #region Commands
    
    #region OpenStationEmulatorCommand
        
    private ICommand _openStationEmulatorCommand;
    public ICommand OpenStationEmulatorCommand => _openStationEmulatorCommand
        ??= new RelayCommand(OnOpenStationEmulatorCommandExecuted, CanOpenStationEmulatorCommandExecute);

    private void OnOpenStationEmulatorCommandExecuted(object parameter)
        => StationEmulatorWindow.Show();
        
    private bool CanOpenStationEmulatorCommandExecute(object parameter) => true;
        
    #endregion
    
    #endregion
    
    public MainViewModel()
    {
        StationEmulatorWindow = new StationEmulatorWindow();

        MainProgramMenuVm = new MainProgramMenuViewModel(this);

        CurrentViewModel = MainProgramMenuVm;
    }
}