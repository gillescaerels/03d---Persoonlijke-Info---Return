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

        private void btnVatSamen_Click(object sender, RoutedEventArgs e)
        {
            string volledigeNaam;
            int lengte;
            int gewicht;
            string rijksRegister;
            string samenVatting;

            volledigeNaam = txtVoornaam.Text + " " + txtFamilienaam.Text;
            gewicht = (int)cmbGewicht.SelectedValue ;
            lengte = (int)cmbLengte.SelectedValue;
            rijksRegister = txtRijksregister.Text;

            samenVatting = "Je naam is " + volledigeNaam + "\n";
            samenVatting += $"Met een gewicht van {gewicht} en een lengte van {lengte} is je BMI {QI(lengte, gewicht)}\n";
            samenVatting += $"Je rijksregisternummer is {rijksRegister.Substring(0, 6)}-{rijksRegister.Substring(6, 3)}" +
            $"-{rijksRegister.Substring(9, 2)}\n";
            samenVatting += "Het controlegetal van je rijksregisternummer is " + RijksRegisterControleGetal(rijksRegister);

            lblSamenvatting.Content = "Samenvatting\n\n" + samenVatting;
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
