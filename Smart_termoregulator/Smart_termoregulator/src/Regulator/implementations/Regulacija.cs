using Smart_termoregulator.src.Regulator.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.implementations
{
    internal class Regulacija : IRegulacija
    {
        //TODO: logovanje
        public void Regulisi(Regulator regulator, src.Heater.implementation.Heater heater)
        {
            regulator.IzracunajSrednjuTemperaturu();
            double srednjaTemp = regulator.SrednjaTemperatura;

            if(regulator.Rezim == rezim_rada.DNEVNI)
            {
                if(regulator.SrednjaTemperatura <= regulator.TempDnevni)
                    heater.HeaterUpaliGrejanje();
                else
                    heater.HeaterUgasiGrejanje();
            }
            else
            {
                if (regulator.SrednjaTemperatura <= regulator.TempNocni)
                    heater.HeaterUpaliGrejanje();
                else
                    heater.HeaterUgasiGrejanje();
            }
        }
    }
}
