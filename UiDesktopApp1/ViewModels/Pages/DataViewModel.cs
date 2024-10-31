using System.Windows.Media;
using UiDesktopApp1.interfaces;
using UiDesktopApp1.Models;
using Wpf.Ui.Controls;

namespace UiDesktopApp1.ViewModels.Pages
{
    public partial class DataViewModel : ObservableObject, INavigationAware
    {
        private bool _isInitialized = false;

        private readonly IDatabase<GangnamguPopulation?>? _database;
        public DataViewModel(IDatabase<GangnamguPopulation?>? database)
        {
            this._database = database;
        }

        [ObservableProperty]
        private IEnumerable<DataColor> _colors;

        [ObservableProperty]
        private IEnumerable<GangnamguPopulation?>? _gannamguPopulations;

        [ObservableProperty]
        private IEnumerable<String?>? _adminstrativeAgency;

        [ObservableProperty]
        private string? _selectedAdminstrativeAgency;

        public void OnNavigatedTo()
        {
            if (!_isInitialized)
                InitializeViewModelAsync();
        }

        public void OnNavigatedFrom() { }

        private async Task InitializeViewModelAsync()
        {
            this.GannamguPopulations = await Task.Run(() => this._database?.Get());

            if(this.GannamguPopulations != null)
            {
                this.AdminstrativeAgency = this.GannamguPopulations.Select(c => c.AdministrativeAgency).ToList();
            }

            _isInitialized = true;
        }
    }
}
