using MD3Desk.ViewModels.Base;
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

    #endregion
    
    public MainViewModel()
    {
        
    }
}