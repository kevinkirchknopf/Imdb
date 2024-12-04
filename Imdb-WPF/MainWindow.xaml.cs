using Imdb_Libary;
using System.Windows;

namespace Imdb_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IAppServices _appServices;

        public MainWindow()
        {
            // Use the services from the App's service provider
            _appServices = (IAppServices)App.Current.Services.GetService(typeof(IAppServices));

            InitializeComponent();
            FilmList.DataContext = _appServices.GetAllFilm();
        }
    }
}
