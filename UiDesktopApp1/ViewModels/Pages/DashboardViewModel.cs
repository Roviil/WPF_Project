using UiDesktopApp1.interfaces;
using UiDesktopApp1.Models;

namespace UiDesktopApp1.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        private readonly IDateTime _idateTime;

        private readonly IDatabase<GangnamguPopulation> _idatabase;

        [ObservableProperty]
        private string? text = string.Empty;

        [ObservableProperty]
        private int _counter = 0;

        [ObservableProperty]
        private String? currentTime = String.Empty;

        public DashboardViewModel(IDateTime dateTime, IDatabase<GangnamguPopulation> database)
        {
            this._idateTime = dateTime;

            this._idatabase = database;
        }

        [RelayCommand]
        private void OnCounterIncrement()
        {
            var datas = this._idatabase.Get();
            this.Text = "Clicked";
        }

        [RelayCommand]
        private void OnTextChanged()
        {
            this.CurrentTime = this._idateTime.GetCurrentTime().ToString();
        }
    }
}
