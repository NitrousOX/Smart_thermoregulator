using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Heater
{
    public enum stanje_peci {UKLJUCEN, ISKLJUCEN}
   
    public class Heater
    {

        private stanje_peci stanje;
        private HeaterPromenaStanja promenaStanja;

        public stanje_peci Stanje { get => stanje; set => stanje = value; }

        public Heater()
        {
            stanje = stanje_peci.ISKLJUCEN;
            promenaStanja = new HeaterPromenaStanja();
        }

        public void HeaterUpaliGrejanje()
        {
            if(stanje == stanje_peci.ISKLJUCEN)
                promenaStanja.Upali(this);
        }

        public void HeaterUgasiGrejanje()
        {
            if(stanje == stanje_peci.UKLJUCEN)
                promenaStanja.Ugasi(this);
        }
    }
}
