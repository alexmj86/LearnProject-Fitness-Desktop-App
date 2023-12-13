using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
        private string userName = "Name"; // Standartwert

        public string UserName
        {
            get { return userName; } 
            set { userName = value; }
        }

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

        private void Eingabe_Geschlecht_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void Eingabe_Alter_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                Eingabe_Geschlecht.Focus();
            }

        }

        private void Eingabe_Groeße_KeyUp(object sender, KeyEventArgs e)
        {

            BMI_Rechner_logic.InputUserSize = Eingabe_Groeße.Text;

            if (e.Key == Key.Enter)
            {
                Eingabe_Alter.Focus();
            }

        }

        private void Berechnen_BMI_Click(object sender, RoutedEventArgs e)
        {
            string eingabeAlter = Eingabe_Alter.Text;
            string eingabeGeschlecht = Eingabe_Geschlecht.Text;

            BMI_Rechner_logic.CalculationBMI();

            if (string.IsNullOrEmpty(Eingabe_Alter.Text) || (string.IsNullOrEmpty(Eingabe_Geschlecht.Text)))
            {
                AusgabeBMI.Text = "Bitte geben ein Alter und das Geschlecht ein.";
            }
            else if (!IstAlterValid(eingabeAlter))
            {
                AusgabeBMI.Text = "Bitte gebe ein Alter größer als 17 ein.";
            }
            else if (!IstGeschlechtValid(eingabeGeschlecht))
            {
                AusgabeBMI.Text = "Bitte gebe ein valides Geschelcht ein.";
            }
            else
            {

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

        private bool IstGeschlechtValid(string geschlecht)
        {
            return geschlecht.ToLower() == "m" || geschlecht.ToLower() == "w";
        }

        private bool IstAlterValid(string alterString)
        {
            if (int.TryParse(alterString, out int alter))
            {
                return alter >= 18;
            }
            return false;
        }

        private void Speichern_BMI_Click(object sender, RoutedEventArgs e)
        {
            // Überprüfen Sie, ob der Benutzer einen gültigen Namen eingegeben hat
            if (UserName == "Name" || string.IsNullOrWhiteSpace(UserName))
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Namen ein.");
                return;
            }

            // Erstellen Sie den Dateinamen basierend auf dem Benutzernamen
            string fileName = $"{UserName}_output.json";

            // Erstellen Sie ein JSON-Objekt mit den erforderlichen Daten
            var dataToSave = new
            {
                UserName,
                BMIValue = BMI_Rechner_logic.FinalOutputUser,
                SaveDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") // Füge das aktuelle Datum und die Uhrzeit hinzu
            };

            try
            {
                // Überprüfen Sie, ob die Datei bereits existiert
                if (System.IO.File.Exists(fileName))
                {
                    // Laden Sie die vorhandenen Daten aus der Datei
                    string existingJson = System.IO.File.ReadAllText(fileName);
                    var existingData = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(existingJson);

                    // Überprüfen Sie, ob das Datum bereits vorhanden ist
                    if (existingData.SaveDate == null)
                    {
                        // Fügen Sie den neuen BMI-Wert und das aktuelle Datum hinzu
                        existingData.BMIValue = BMI_Rechner_logic.FinalOutputUser;
                        existingData.SaveDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        // Konvertieren Sie das Objekt in JSON und aktualisieren Sie die Datei
                        string updatedJson = Newtonsoft.Json.JsonConvert.SerializeObject(existingData);
                        System.IO.File.WriteAllText(fileName, updatedJson);

                        MessageBox.Show($"Daten für {UserName} erfolgreich aktualisiert!");
                    }
                    else
                    {
                        MessageBox.Show($"Die Daten für {UserName} wurden bereits gespeichert. Keine Aktualisierung vorgenommen.");
                    }
                }
                else
                {
                    // Die Datei existiert nicht, daher erstellen Sie eine neue Datei
                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(dataToSave);
                    System.IO.File.WriteAllText(fileName, json);

                    MessageBox.Show($"Daten für {UserName} erfolgreich gespeichert!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern der Daten: {ex.Message}");
            }
        }

        private void Eingabe_Name_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (textBox.Text == "Name")
            {
                textBox.Text = "";
            }
        }
        private void Eingabe_Name_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Name";
            }
            else
            {
                UserName = textBox.Text;
            }
        }

        private void Eingabe_Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
