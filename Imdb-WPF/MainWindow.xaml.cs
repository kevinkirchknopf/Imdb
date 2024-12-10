using Imdb_Libary;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.ObjectModel;
using System.Windows;

namespace Imdb_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IAppServices _appServices;

        public MainWindow()
        {
            InitializeComponent();
            _appServices = App.Current.Services.GetService<IAppServices>();
            ObservableCollection<Film> Filmek = _appServices.GetAllFilm();
            this.DataContext = Filmek;
        }
    }
}
