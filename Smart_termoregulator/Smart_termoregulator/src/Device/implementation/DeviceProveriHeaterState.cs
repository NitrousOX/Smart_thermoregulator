using Smart_termoregulator.src.Device.interfaces;
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
            int vremeProvere = int.Parse(ConfigurationManager.AppSettings["vremeProvereTempDevice"]);
            while (true)
            {
                Thread.Sleep(vremeProvere);     //na svaka 2 min  120000
                if (device.HeaterState)
                    device.DevicePovecajTemperaturu();
                else
                    device.DeviceSmanjiTemperaturu();
            }
        }

    }
}
