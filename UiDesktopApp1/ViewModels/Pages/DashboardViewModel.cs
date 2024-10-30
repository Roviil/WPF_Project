using UiDesktopApp1.interfaces;

namespace UiDesktopApp1.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        private readonly IDateTime _idateTime;

        [ObservableProperty]
        private string? text = string.Empty;

        [ObservableProperty]
        private int _counter = 0;

        [ObservableProperty]
        private String? currentTime = String.Empty;

        public DashboardViewModel(IDateTime dateTime)
        {
            this._idateTime = dateTime;
        }

        [RelayCommand]
        private void OnCounterIncrement()
        {
            this.Text = "Clicked";
        }

        [RelayCommand]
        private void OnTextChanged()
        {
            this.CurrentTime = this._idateTime.GetCurrentTime().ToString();
        }
    }
}
