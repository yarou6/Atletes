using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для LoginWPF.xaml
    /// </summary>
    public partial class LoginWPF : Window
    {
        public LoginWPF()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void ButtonVhod(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            Hide();
            window.ShowDialog();
            Show();
            
        }
    }
}
