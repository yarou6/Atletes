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
    /// Логика взаимодействия для AddAthlete.xaml
    /// </summary>
    public partial class AddAthlete : Window, INotifyPropertyChanged
    {
        _1135AlexandroDobruchoContext db;

        private Category selectedcategory;

        public event PropertyChangedEventHandler? PropertyChanged;
        void Signal([CallerMemberName] string prop = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        public AddAthlete()
        {
            InitializeComponent();

            DataContext = this;

            db = new _1135AlexandroDobruchoContext();

            Category = db.Categories.ToList();


        }
        public List<Category> Category { get; set; }

        public Category SelectedCategory
        {
            get => selectedcategory;
            set
            {
                selectedcategory = value;
                Signal();
            }
        }
        private void AddAthletePlz(object sender, RoutedEventArgs e)
        {

        }
    }
}
