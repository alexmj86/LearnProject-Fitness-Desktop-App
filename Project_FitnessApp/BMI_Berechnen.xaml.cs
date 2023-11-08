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
    /// Interaktionslogik für BMI_Berechnen.xaml
    /// </summary>
    public partial class BMI_Berechnen : Window
    {
        public Hyperlink LinkToTK { get; private set; }

        public BMI_Berechnen()
        {
            InitializeComponent();
        }

        private void Eingabe_Kilogramm_KeyUp(object sender, KeyEventArgs e)
        {
            BMI_Rechner_logic.InputUserWeight = Eingabe_Kilogramm.Text;

            
            if (e.Key == Key.Enter)
            {
                Eingabe_Groeße.Focus();
            }


        }

        private void Eingabe_Groeße_KeyUp(object sender, KeyEventArgs e)
        {

            BMI_Rechner_logic.InputUserSize = Eingabe_Groeße.Text;

        }

        private void Berechnen_BMI_Click(object sender, RoutedEventArgs e)
        {
            BMI_Rechner_logic.CalculationBMI();

            

            if (BMI_Rechner_logic.FinalOutputUser < 16)
            {
                AusgabeBMI.Text = $"Der BMI von {BMI_Rechner_logic.FinalOutputUser} liegt im Kritisches Untergewicht unter 51,8 kg.\n\nEinschätzung:\n\n" +
                    $"Achtung: Ein BMI-Wert unter 17,5 ist bedenklich und gilt bei Männern wie Frauen als anorektisch.\n" +
                    $"Um mit einem viel zu niedrigen Körpergewicht nicht die Gesundheit zu gefährden,\n" +
                    $"sollten Sie bei einem solchen Ergebnis dringend einen Arzt aufsuchen.\n\n" +
                $"https://www.tk.de/techniker/magazin/ernaehrung/themenspezial-ernaehrung/gestoertes-essverhalten-2086488";
            }
            else if (BMI_Rechner_logic.FinalOutputUser >= 16 && BMI_Rechner_logic.FinalOutputUser < 18.49)
            {
                AusgabeBMI.Text = $"Der BMI von {BMI_Rechner_logic.FinalOutputUser} liegt im Untergewicht 51,8 - 71,0 kg.\n\nEinschätzung:\n\n" +
                    $"Ihr BMI ist sehr niedrig.\n" +
                    $"Nur mit der richtigen Ernährung und dem passenden Maß an Bewegung bleiben Sie langfristig gesund.\n" +
                    $"Die Techniker oder Ihr Arzt unterstützen Sie gern.\n\n" +
                "https://www.tk.de/techniker/magazin/ernaehrung/themenspezial-ernaehrung/gesund-essen-2086486";
            }
            else if (BMI_Rechner_logic.FinalOutputUser >= 18.5 && BMI_Rechner_logic.FinalOutputUser < 25)
            {
                AusgabeBMI.Text = $"Der BMI von {BMI_Rechner_logic.FinalOutputUser} liegt im Normalgewicht 71,0 - 88,8 kg.\n\nEinschätzung:\n\n" +
                    $"Super! Ihr Gewicht ist gesund.\n" +
                    $"Mit einer ausgewogenen Ernährung und regelmäßiger Bewegung wird das auch langfristig so bleiben.\n\n" +
                "https://www.tk.de/techniker/magazin/ernaehrung/themenspezial-ernaehrung/normalgewicht-2086484";

            }
            else if (BMI_Rechner_logic.FinalOutputUser >= 25 && BMI_Rechner_logic.FinalOutputUser < 30)
            {
                AusgabeBMI.Text = $"Der BMI von {BMI_Rechner_logic.FinalOutputUser} liegt im leichtes Übergewicht 88,8 - 103,5 kg.\n\nEinschätzung:\n\n" +
                    $"Ihr BMI ist leicht erhöht.\n" +
                    $"Achten Sie auf Ihre Ernährung und bewegen Sie sich regelmäßig.\n" +
                    $"So können Sie das Risiko für mögliche Begleiterkrankungen minimieren.\n\n" +
                "https://www.tk.de/techniker/magazin/ernaehrung/themenspezial-ernaehrung/jetzt-nehme-ich-ab-2086482";

            }
            else if (BMI_Rechner_logic.FinalOutputUser >= 30)
            {
                AusgabeBMI.Text = $"Der BMI von {BMI_Rechner_logic.FinalOutputUser} liegt im Übergewicht über 103,5 kg.\n\nEinschätzung:\n\n" +
                    $"Ihr BMI weist auf Übergewicht hin.\n" +
                    $"Das birgt die Gefahr von Krankheiten wie etwa Diabetes.\n" +
                    $"Ihr Hausarzt und die Techniker unterstützen Sie gern bei einem gesunden Lebensstil..\n\n" +
                "https://www.tk.de/techniker/magazin/ernaehrung/themenspezial-ernaehrung/uebergewicht-in-den-griff-bekommen-2086480";
            }
            else
            {
                AusgabeBMI.Text = "Fehler";
            }


        }


    }
}
