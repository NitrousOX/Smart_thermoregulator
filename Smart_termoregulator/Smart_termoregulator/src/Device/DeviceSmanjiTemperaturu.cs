using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Device
{
    public class DeviceSmanjiTemperaturu : ISmanjiTemperaturu
    {
        private Device d = new Device();
        public void SmanjiTemperaturu()
        {
            d.Temperatura =- Temperature_difference.temperature_difference;
        }
    }
}
