using Atletes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Atletes.View
{
    /// <summary>
    /// Логика взаимодействия для AddTraining.xaml
    /// </summary>
    public partial class AddTraining : Window, INotifyPropertyChanged
    {
        _1135AlexandroDobruchoContext db;

        private Model.Type selectedtype;

        public event PropertyChangedEventHandler? PropertyChanged;
        void Signal([CallerMemberName] string prop = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        public AddTraining()
        {
            InitializeComponent();

            DataContext = this;

            db = new _1135AlexandroDobruchoContext();

            Types = db.Types.ToList();


        }

        public List<Model.Type> Types { get; set; }

        public Model.Type SelectedType
        {
            get => selectedtype;
            set
            {
                selectedtype = value;
                Signal();
            }
        }
        private void AddTrainingPlz(object sender, RoutedEventArgs e)
        {

        }
    }
}
