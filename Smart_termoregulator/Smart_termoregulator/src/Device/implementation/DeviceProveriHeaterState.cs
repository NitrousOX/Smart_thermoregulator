using Smart_termoregulator.src.Device.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Device.implementation
{
    public class DeviceProveriHeaterState : IProveraHeaterState
    {
        public void proveriHeaterState(Device device)
        {
            while (true)
            {
                Thread.Sleep(1000);     //na svaka 2 min  120000
                if (device.HeaterState)
                    device.DevicePovecajTemperaturu();
                else
                    device.DeviceSmanjiTemperaturu();
            }
        }

    }
}
