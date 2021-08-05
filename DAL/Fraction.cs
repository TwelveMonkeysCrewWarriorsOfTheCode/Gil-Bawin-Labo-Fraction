using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using CsvHelper;
using DTO;

namespace DAL
{
    public class Fraction
    {
        public static bool SaveToFile(string[] movesToSave, SaveType saveType)
        {
            string fileLocation;
            string textToSave;

            switch (saveType)
            {
                case SaveType.Calculation:
                    fileLocation = @".\SavedCalculations.csv";
                    break;
                case SaveType.Comparison:
                    fileLocation = @".\SavedComparisons.csv";
                    break;
                default:
                    return false;
            }

            if (!File.Exists(fileLocation))
            {
                switch (saveType)
                {
                    case SaveType.Calculation:
                        File.WriteAllText(fileLocation, "Date;Heure;Fraction 1;Operateur;Fraction 2;Resultat\n");
                        break;
                    case SaveType.Comparison:
                        File.WriteAllText(fileLocation, "Date;Heure;Fraction 1;Comparateur;Fraction 2;Resultat\n");
                        break;
                }
            }

            textToSave = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + ";";
            textToSave += DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + ";";
            foreach (string move in movesToSave)
            {
                textToSave += " " + move + ";";
            }
            textToSave += "\n";

            File.AppendAllText(fileLocation, textToSave);

            return true;
        }
    }
}
