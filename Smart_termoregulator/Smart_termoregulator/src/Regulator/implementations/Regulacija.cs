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
            while (true)
            {
                Thread.Sleep(100);
                regulator.IzracunajSrednjuTemperaturu();
                double srednjaTemp = regulator.SrednjaTemperatura;

                if (regulator.Rezim == rezim_rada.DNEVNI)
                {
                    if (regulator.SrednjaTemperatura <= regulator.TempDnevni)
                    {
                        heater.HeaterUpaliGrejanje();
                        foreach (src.Device.implementation.Device device in regulator.Uredjaji)
                        {
                            device.HeaterState = true;
                        }
                        LogType.logRegulator(1);
                    }
                    else
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
                        heater.HeaterUpaliGrejanje();
                        foreach (src.Device.implementation.Device device in regulator.Uredjaji)
                        {
                            device.HeaterState = true;
                        }
                        LogType.logRegulator(1);
                    }
                    else
                    {
                        heater.HeaterUgasiGrejanje();
                        foreach (src.Device.implementation.Device device in regulator.Uredjaji)
                        {
                            device.HeaterState = false;
                        }
                        LogType.logRegulator(2);
                    }
                }
            }
        }
    }
}
