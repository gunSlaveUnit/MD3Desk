using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace MD3Desk.Views.Windows
{
    public partial class StationEmulatorWindow : Window, INotifyPropertyChanged
    {
        #region Properties

        public double FontScale { get; set; } = 1.0;
    
        #endregion
        
        public StationEmulatorWindow()
        {
            InitializeComponent();
            calcucateFontScale();
        }
        
        private void WindowSizeChanged(object sender, RoutedEventArgs e)
        {
            calcucateFontScale();
        }

        private void calcucateFontScale()
        {
            FontScale = (Height + Width) / 160;
            OnPropertyChanged("FontScale");
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}