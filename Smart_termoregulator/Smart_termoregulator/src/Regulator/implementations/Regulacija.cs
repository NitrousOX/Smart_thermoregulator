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
            int vremeProvere;
            if (ConfigurationManager.AppSettings["vremeProvereTempRegulator"] != null)
            {
                vremeProvere = int.Parse(ConfigurationManager.AppSettings["vremeProvereTempRegulator"]);
            }
            else
            {
                vremeProvere = 120000; 
            }
            while (true)
            {
                regulator.IzracunajSrednjuTemperaturu();
                double srednjaTemp = regulator.SrednjaTemperatura;
                LogType.logRegulator(3);


                if (regulator.Rezim == rezim_rada.DNEVNI)
                {
                    if (regulator.SrednjaTemperatura <= regulator.TempDnevni)
                    {
                        if (heater.Stanje == stanje_peci.ISKLJUCEN)
                        {
                            lock (heater)
                            {
                                heater.HeaterUpaliGrejanje();
                            }

                            foreach (src.Device.implementation.Device device in regulator.Uredjaji)
                            {
                                lock (device)
                                {
                                    device.HeaterState = true;
                                }
                            }
                            LogType.logRegulator(1);
                        }
                    }
                    else if (heater.Stanje == stanje_peci.UKLJUCEN)
                    {
                        lock (heater)
                        {
                            heater.HeaterUgasiGrejanje();
                        }
                        foreach (src.Device.implementation.Device device in regulator.Uredjaji)
                        {
                            lock (device)
                            {
                                device.HeaterState = false;
                            }
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
                            lock (heater)
                            {
                                heater.HeaterUpaliGrejanje();
                            }
                            foreach (src.Device.implementation.Device device in regulator.Uredjaji)
                            {
                                lock (device)
                                {
                                    device.HeaterState = true;
                                }
                            }
                            LogType.logRegulator(1);
                        }
                    }
                    else if (heater.Stanje == stanje_peci.UKLJUCEN)
                    {
                        lock (heater)
                        {
                            heater.HeaterUgasiGrejanje();
                        }
                        foreach (src.Device.implementation.Device device in regulator.Uredjaji)
                        {
                            lock (device)
                            {
                                device.HeaterState = false;
                            }
                        }
                        LogType.logRegulator(2);
                    }
                }
                Thread.Sleep(vremeProvere);
            }
        }
    }
}
