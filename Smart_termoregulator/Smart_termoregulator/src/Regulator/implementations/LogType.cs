using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.implementations
{
    internal class LogType : LogovanjeDesavanja
    {
        public static void logDevice(int i)
        {
            string text;
            switch (i)
            {  
                case 0: text = "Dodat je novi Uredjaj";
                    break;
                case 1: text = "Povecana temperatura";
                    break;
                case 2: text = "Smanjena temperatura";
                    break;
                default: text = "ERROR";
                    break;
            }

            Loguj(text);
        }

        public static void logRegulator(int i)
        {
            string text;
            switch (i)
            {
                case 0:
                    text = "Uneti novi rezimi rada";
                    break;
                case 1:
                    text = "Regulator pali heater";
                    break;
                case 2:
                    text = "Regulator gasi heater";
                    break;
                case 3:
                    text = "Regulator je proverio temp";
                    break;
                default:
                    text = "ERROR";
                    break;
            }

            Loguj(text);
        }

        public static void logHeater(int i)
        {
            string text;
            switch (i)
            {
                case 0:
                    text = "";
                    break;
                case 1:
                    text = "";
                    break;
                case 2:
                    text = "";
                    break;
                default:
                    text = "ERROR";
                    break;
            }

            Loguj(text);
        }
    }
}
