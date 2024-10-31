using UiDesktopApp1.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace UiDesktopApp1.Views.Pages
{
    public partial class DataPage : INavigableView<DataViewModel>
    {
        public DataViewModel ViewModel { get; }

        public DataPage(DataViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            ViewModel.PropertyChanged += ViewModel_PropertyChanged;
            InitializeComponent();
        }

        private void ViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "AdminstrativeAgency":
                    this.searchGridLodingControl.Visibility = Visibility.Collapsed;
                    this.searchGrid.Visibility = Visibility.Visible;
                    break;
                case "GannamguPopulations":
                    this.dgGridLodingControl.Visibility= Visibility.Collapsed;
                    this.dgGrid.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void cbxAdminAgency_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
