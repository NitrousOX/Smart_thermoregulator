using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_termoregulator.src.Heater.Interfaces;

namespace Smart_termoregulator.src.Heater.implementation
{
    internal class HeaterPromenaStanja : IPromenaStanja
    {
        HeaterVreme vreme = new HeaterVreme();
        heaterUpisBaza upis = new heaterUpisBaza();
        public void Upali(Heater heater)
        {
            heater.Stanje = stanje_peci.UKLJUCEN;
            vreme.Start = DateTime.Now;
            upis.UpisiUBazu(vreme.Start);
        }

        public void Ugasi(Heater heater)
        {
            heater.Stanje = stanje_peci.ISKLJUCEN;
            vreme.Time = DateTime.Now;
            vreme.ProtekloVreme = vreme.Time - vreme.Start;
            upis.UpisiUBazu(vreme);
        }
    }
}
