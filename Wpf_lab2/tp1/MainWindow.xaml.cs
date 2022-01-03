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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello WPF");
        }

        private void key_Up_Click(object sender, KeyEventArgs e)
        {
            MessageBox.Show("key_Up");
        }

        private void key_Down_Click(object sender, KeyEventArgs e)
        {
            MessageBox.Show("key_Down");
        }

        private void btnMakeCoffee_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "Your coffee is on its way.";

        }
    }
}
