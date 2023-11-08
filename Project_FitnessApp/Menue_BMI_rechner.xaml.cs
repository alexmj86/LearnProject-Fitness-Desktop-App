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

namespace Project_FitnessApp
{
    /// <summary>
    /// Interaktionslogik für Menue_BMI_rechner.xaml
    /// </summary>
    public partial class Menue_BMI_rechner : Window
    {
        public Menue_BMI_rechner()
        {
            InitializeComponent();
        }

        private void BTN_BMI_berechnen_Click(object sender, RoutedEventArgs e)
        {
            BMI_Berechnen bmiBerechnen = new BMI_Berechnen();
            bmiBerechnen.Show();
        }
    }
}
