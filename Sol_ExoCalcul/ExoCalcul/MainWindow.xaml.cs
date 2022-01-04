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
using System.IO;

namespace ExoCalcul
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

        private void somme_btn(object sender, RoutedEventArgs e)
        {
            // faire la somme de val1 et val2
            //double res = double.Parse(TextBox1.Text) + double.Parse(TextBox2.Text);
            //labelSome.Content = "La somme  = "+ res;
            //MessageBox.Show("La somme = ", "Résulat");

            //var NewWindow = new Calculatrice();
            //NewWindow.Show();
            //var AddStudent = new AddStudent();
           // AddStudent.Show();
        
            string path = @"C:\Users\amine\Desktop\Lab\operations_du_Jours.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = "Log du jour" + Environment.NewLine;
                File.WriteAllText(path, createText, Encoding.UTF8); // creation
            }

           
            string appendText = "[Operations somme : " + DateTime.Now + " ]" + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);
            

      
        }
    }
}
