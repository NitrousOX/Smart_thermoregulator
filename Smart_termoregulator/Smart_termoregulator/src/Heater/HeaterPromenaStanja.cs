using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Heater
{
    public class HeaterPromenaStanja
    {
        HeaterVreme vreme = new HeaterVreme();
        IupisUBazu upis = new heaterUpisBaza();
        public void Upali(Heater heater)
        {
            heater.Stanje = stanje_peci.ukljucen;
            vreme.Start = DateTime.Now;
            upis.UpisiUBaziPaljenje;
        }

        public void Ugasi(Heater heater)
        {
            heater.Stanje = stanje_peci.iskljucen;
            vreme.Time = DateTime.Now;
            upis.UpisiUBazu(vreme);
        }
    }
}
