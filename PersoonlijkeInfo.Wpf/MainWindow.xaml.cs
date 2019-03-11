using System;
using System.Windows;

namespace PersoonlijkeInfo.Wpf
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

        void VulBoxen()
        {
            cmbGewicht.Items.Add(65);
            cmbGewicht.Items.Add(70);
            cmbGewicht.Items.Add(75);
            cmbGewicht.Items.Add(80);
            cmbGewicht.Items.Add(85);

            cmbLengte.Items.Add(150);
            cmbLengte.Items.Add(160);
            cmbLengte.Items.Add(170);
            cmbLengte.Items.Add(180);
            cmbLengte.Items.Add(185);
        }



        float QI(int lengte, int gewicht)
        {
            float lengteInMeter = lengte / 100F;
            float bmi;
            bmi = (float)gewicht / (lengteInMeter * lengteInMeter);
            return bmi;
        }

        int RijksRegisterControleGetal(string rijksRegisterNr)
        {
            int rijksRegisterControle;
            int rijksRegister9chars;
            rijksRegister9chars = int.Parse(rijksRegisterNr.Substring(0, 9));
            rijksRegisterControle = 97 - (rijksRegister9chars % 97);
            return rijksRegisterControle; 
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VulBoxen();
        }
    }
}
