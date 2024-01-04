using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_termoregulator.src.Device.interfaces;

namespace Smart_termoregulator.src.Device.implementation
{
    public class DeviceSlanje : ISlanjeTemperature
    {
        private Device d = new Device();
        public float PosaljiTemperaturu()
        {
            return d.Temperatura;
        }

    }
}
