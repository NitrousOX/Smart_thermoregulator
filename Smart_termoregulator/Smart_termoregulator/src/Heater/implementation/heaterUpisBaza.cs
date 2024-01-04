using Smart_termoregulator.src.FileUpis;
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
        private UpisiUtxtFile upis;
        public const double kWh_per_s = 0.000317;

        public void UpisiUBazu(HeaterVreme informacijeZaVreme)
        {
            List<string> text = new List<string>();
            double energija = kWh_per_s * informacijeZaVreme.ProtekloVreme.TotalSeconds;

            upis = new UpisiUtxtFile();
            text.Add("[HEATER] Ugasen " + informacijeZaVreme.Time.ToString());
            text.Add("[HEATER] proteklo vreme rada je: " + informacijeZaVreme.ProtekloVreme.ToString() + " potroseno " + energija + " kWh");
            upis.UpisiUFile(text, fileName);
        }

        public void UpisiUBazu(DateTime trenutno)
        {
            List<string> text = new List<string>();
            upis = new UpisiUtxtFile();
            text.Add("[HEATER] Upaljen " + trenutno.ToString());
            upis.UpisiUFile(text, fileName);
        }
    }
}
