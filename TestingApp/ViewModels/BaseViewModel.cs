using System;
using System.ComponentModel;

namespace TestingApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void SetProperty<T>(ref T field, T value, [System.Runtime.CompilerServices.CallerMemberName]string propertyname = null)
        {
            field = value;
            ChangeProperty(propertyname);
        }

        public void ChangeProperty(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void DisplayError(string title, string message, string button)
        {
            App.Current.MainPage.DisplayAlert(title, message, button);
        }
    }
}
