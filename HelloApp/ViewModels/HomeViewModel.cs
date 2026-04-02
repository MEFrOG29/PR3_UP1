using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using static System.Net.Mime.MediaTypeNames;

namespace HelloApp.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string text = "Hello, Avalonia!";

        [RelayCommand]
        public void ChangeText()
        {
            Text = "New text";
        }

    }
}
