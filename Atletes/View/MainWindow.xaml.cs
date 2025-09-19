using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Atletes.Model;

namespace Atletes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        _1135AlexandroDobruchoContext db;

        private Training selectedtraining;

        public event PropertyChangedEventHandler? PropertyChanged;
        void Signal([CallerMemberName] string prop = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public List<Athlete> Athletes { get; set; }
        public List<Category> Categories { get; set; }
        public List<Training> Trainings { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            db = new _1135AlexandroDobruchoContext();

            Athletes = db.Athletes.ToList();
            Categories = db.Categories.ToList();

        }
        public Training SelectedTraining
        {
            get => selectedtraining;
            set
            {
                selectedtraining = value;
                Signal();
            }
        }
        private void AddAthleteAndTraining(object sender, RoutedEventArgs e)
        {

        }
    }
}