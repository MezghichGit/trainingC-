using GestionEcole.Models;
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

namespace GestionEcole
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Groupe groupe = new Groupe { Libelle = "Nom du groupe", Nombre = 0 };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = groupe;
        }

        private void btnAddGroupe(object sender, RoutedEventArgs e)
        {
            using (var db = new EFContext())
            {
       
                db.Add(groupe);

                db.SaveChanges();
            }

            MessageBox.Show("Ajout avec succès", "Félicitations");
        }
    }
}
