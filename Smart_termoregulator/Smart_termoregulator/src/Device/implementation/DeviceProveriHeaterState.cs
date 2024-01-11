using Smart_termoregulator.src.Device.interfaces;
using Smart_termoregulator.src.Regulator.implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Smart_termoregulator.src.Device.implementation
{
    public class DeviceProveriHeaterState : IProveraHeaterState
    {
        public void proveriHeaterState(Device device)
        {
            int vremeProvere;
            if (ConfigurationManager.AppSettings["vremeProvereTempDevice"] != null)
            {
                vremeProvere = int.Parse(ConfigurationManager.AppSettings["vremeProvereTempDevice"]);
            }
            else
            {
                vremeProvere = 180000;
            }
            while (true)
            {
                Thread.Sleep(vremeProvere);
                lock (device)
                {
                    if (device.HeaterState)
                        device.DevicePovecajTemperaturu();
                    else
                        device.DeviceSmanjiTemperaturu();
                }
            }
        }

    }
}
