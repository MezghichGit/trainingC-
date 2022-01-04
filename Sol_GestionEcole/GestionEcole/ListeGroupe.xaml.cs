using GestionEcole.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;

namespace GestionEcole
{
    /// <summary>
    /// Logique d'interaction pour ListeGroupe.xaml
    /// </summary>
    public partial class ListeGroupe : Window
    {
        public ListeGroupe()
        {
            InitializeComponent();
        
            List<Groupe> items;
            using (var db = new EFContext())
            {
                items = db.DAOGroupes.ToList();
                
            }
            
           listeGroupe.ItemsSource = items;


            
            
        }
    }
}
