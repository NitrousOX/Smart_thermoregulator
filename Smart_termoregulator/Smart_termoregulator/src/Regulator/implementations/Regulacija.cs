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
        
        public void Regulisi(Regulator regulator, src.Heater.implementation.Heater heater)
        {
            regulator.IzracunajSrednjuTemperaturu();
            double srednjaTemp = regulator.SrednjaTemperatura;

            if(regulator.Rezim == rezim_rada.DNEVNI)
            {
                if (regulator.SrednjaTemperatura <= regulator.TempDnevni)
                {
                    heater.HeaterUpaliGrejanje();
                    LogType.logRegulator(1);
                }
                else
                {
                    heater.HeaterUgasiGrejanje();
                    LogType.logRegulator(2);
                }
            }
            else
            {
                if (regulator.SrednjaTemperatura <= regulator.TempNocni)
                {
                    heater.HeaterUpaliGrejanje();
                    LogType.logRegulator(1);
                }
                else
                {
                    heater.HeaterUgasiGrejanje();
                    LogType.logRegulator(2);
                }
            }
        }
    }
}
