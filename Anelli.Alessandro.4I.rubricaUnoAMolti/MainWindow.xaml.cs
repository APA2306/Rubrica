﻿using Anelli.Alessandro._4I.rubricaUnoAMolti.Models;
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
        Contatti contatti = new Contatti();
        Persone persone = new Persone();
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            contatti = new("Data/Contatti.csv");
            dataGridContatti.ItemsSource = contatti;
            persone = new("Data/Persone.csv");
            dataGridPersone.ItemsSource = persone;
            
            //Prima soluzione per leggere i file
            //try 
            //{ 
            //StreamReader fcontatti = new StreamReader("Data/Contatti.csv");
            //fcontatti.ReadLine();
            //while(!fcontatti.EndOfStream) 
            //{
            //string rigac = fcontatti.ReadLine();
            //Contatto c = new Contatto(rigac);
            //contatti.Add(c);
            //}

            //dataGridContatti.ItemsSource = contatti;

            //StreamReader fpersone = new StreamReader("Data/Persone.csv");
            //fpersone.ReadLine();
            //while (!fpersone.EndOfStream)
            //{
            //    string rigap = fpersone.ReadLine();
            // Persona c = new Persona(rigap);
            // persone.Add(c);
            //}
            //persone = new Persone("Persone.csv");
            //dataGridPersone.ItemsSource = persone;

            //}
            //catch  
            //{
            //MessageBox.Show("Possibile problema nei file .csv");
            //Environment.Exit(0);
            //}
        }

        private void dataGridPersone_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Persona p = e.AddedItems[0] as Persona;

            if( p != null ) 
            {
                statusBar.Text = $"hai selezionato {p.Nome} {p.Cognome}";

                Contatti contattifiltrati = new();
                foreach (var item in contatti)
                    if(item.IdPersona == p.IdPersona)
                        contattifiltrati.Add(item);
                dataGridContatti.ItemsSource = contattifiltrati;
            }
        }

        private void dataGridContatti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    
}
