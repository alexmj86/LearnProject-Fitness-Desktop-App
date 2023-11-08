using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FitnessApp
{
    class BMI_Rechner_logic
    {
        public static string InputUserWeight { get; set; }
        public static string InputUserSize { get; set; }
        public static double FinalOutputUser { get; set; }

        public static double CalculationBMI()
        {

            if (double.TryParse(InputUserWeight, out double number1) && double.TryParse(InputUserSize, out double number2))
            {
                double ChangeInCm = number2 / 100;
                double calculateSize = ChangeInCm * ChangeInCm;
                FinalOutputUser = number1 / calculateSize;
                FinalOutputUser = Math.Round(FinalOutputUser, 2);
                Console.WriteLine($"\nIhr BMI beträgt {FinalOutputUser}.");
                return FinalOutputUser;
            }
            else
            {
                Console.WriteLine("Es sind nur Zahlen erlaubt!!\nDas Programm können Sie neu starten.");
                Console.ReadLine();
                return FinalOutputUser;
            }
        }


    }
}
