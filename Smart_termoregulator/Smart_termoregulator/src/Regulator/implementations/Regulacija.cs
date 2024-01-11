using Smart_termoregulator.src.Heater.implementation;
using Smart_termoregulator.src.Regulator.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Smart_termoregulator.src.Regulator.implementations
{
    internal class Regulacija : IRegulacija
    {
        
        public void Regulisi(Regulator regulator, src.Heater.implementation.Heater heater)
        {
            int vremeProvere = int.Parse(ConfigurationManager.AppSettings["vremeProvereTempRegulator"]);
            while (true)
            {
                regulator.IzracunajSrednjuTemperaturu();
                double srednjaTemp = regulator.SrednjaTemperatura;


                if (regulator.Rezim == rezim_rada.DNEVNI)
                {
                    if (regulator.SrednjaTemperatura <= regulator.TempDnevni)
                    {
                        if (heater.Stanje == stanje_peci.ISKLJUCEN)
                        {
                            heater.HeaterUpaliGrejanje();
                            foreach (src.Device.implementation.Device device in regulator.Uredjaji)
                            {
                                device.HeaterState = true;
                            }
                            LogType.logRegulator(1);
                        }
                    }
                    else if (heater.Stanje == stanje_peci.UKLJUCEN)
                    {
                        heater.HeaterUgasiGrejanje();
                        foreach (src.Device.implementation.Device device in regulator.Uredjaji)
                        {
                            device.HeaterState = false;
                        }
                        LogType.logRegulator(2);
                    }
                }
                else
                {
                    if (regulator.SrednjaTemperatura <= regulator.TempNocni)
                    {
                        if (heater.Stanje == stanje_peci.ISKLJUCEN)
                        {
                            heater.HeaterUpaliGrejanje();
                            foreach (src.Device.implementation.Device device in regulator.Uredjaji)
                            {
                                device.HeaterState = true;
                            }
                            LogType.logRegulator(1);
                        }
                    }
                    else if (heater.Stanje == stanje_peci.UKLJUCEN)
                    {
                        heater.HeaterUgasiGrejanje();
                        foreach (src.Device.implementation.Device device in regulator.Uredjaji)
                        {
                            device.HeaterState = false;
                        }
                        LogType.logRegulator(2);
                    }
                }
                Thread.Sleep(vremeProvere);
            }
        }
    }
}
