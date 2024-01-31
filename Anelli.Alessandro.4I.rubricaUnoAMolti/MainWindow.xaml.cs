using Anelli.Alessandro._4I.rubricaUnoAMolti.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Anelli.Alessandro._4I.rubricaUnoAMolti
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try 
            { 
                List<Contatto> contatti = new List<Contatto>();
                StreamReader fcontatti = new StreamReader("Data/Contatti.csv");
                fcontatti.ReadLine();
                while(!fcontatti.EndOfStream) 
                {
                    string rigac = fcontatti.ReadLine();
                    Contatto c = new Contatto(rigac);
                    contatti.Add(c);
                }

                dataGridContatti.ItemsSource = contatti;

                List<Persona> persone = new List<Persona>();
                StreamReader fpersone = new StreamReader("Data/Persone.csv");
                fpersone.ReadLine();
                while (!fpersone.EndOfStream)
                {
                    string rigap = fpersone.ReadLine();
                    Persona c = new Persona(rigap);
                    persone.Add(c);
                }

                dataGridPersone.ItemsSource = persone;

            }
            catch { }
        }
    }
    
}
