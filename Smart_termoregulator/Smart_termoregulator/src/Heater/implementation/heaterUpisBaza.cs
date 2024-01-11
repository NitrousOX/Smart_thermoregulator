using Smart_termoregulator.src.FileUpis;
using Smart_termoregulator.src.Heater.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Heater.implementation
{
    internal class heaterUpisBaza : IupisUBazu
    {
        private readonly string fileName = "HeaterBaza.txt";
        private const double kWh_per_s = 0.000317;

        public void UpisiUBazu(HeaterVreme informacijeZaVreme)
        {
            List<string> text = new List<string>();
            double energija = kWh_per_s * informacijeZaVreme.ProtekloVreme.TotalSeconds;

            text.Add("[HEATER] Ugasen " + informacijeZaVreme.Time.ToString());
            text.Add("[HEATER] proteklo vreme rada je: " + informacijeZaVreme.ProtekloVreme.ToString() + " potroseno " + energija + " kWh");
            src.FileUpis.UpisiUtxtFile.UpisiUFile(text, fileName);
        }

        public void UpisiUBazu(DateTime trenutno)
        {
            string text;
            text = "[HEATER] Upaljen " + trenutno.ToString();
            src.FileUpis.UpisiUtxtFile.UpisiUFile(text, fileName);
        }
    }
}
