using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.implementations
{
    internal class LogType : LogovanjeDesavanja
    {
        public void logDevice(int i)
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

        public void logRegulator()
        {

        }

        public void logHeater()
        {

        }
    }
}
