using System.Windows.Media;
using UiDesktopApp1.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace UiDesktopApp1.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel>
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            ViewModel.PropertyChanged += ViewModel_PropertyChanged;

            InitializeComponent();
        }

        private void ViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "Text":
                    this.btnClickMe.Background =new  SolidColorBrush(Colors.Black);
                    break;

            }
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
