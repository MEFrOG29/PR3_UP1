using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace HelloApp.ViewModels
{
    public partial class ControlsViewModel : ViewModelBase
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Age))]
        private DateTime selectedDate;

        public int Age => (DateTime.Now.Year - SelectedDate.Year -
                    (DateTime.Now.DayOfYear < SelectedDate.DayOfYear ? 1 : 0));

        public string[] Languages { get; set; } = ["Java", "Python", "C#", "TypeScript"];

        [ObservableProperty]
        public string selectedLanguage;

        [ObservableProperty]
        public double opacityValue = 1.0;

        [ObservableProperty]
        public bool _isSettingsEnabled = true;

    }
}
