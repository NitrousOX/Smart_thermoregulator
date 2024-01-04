using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_termoregulator.src.Device.interfaces;

namespace Smart_termoregulator.src.Device.implementation
{
    public class DevicePovecajTemeraturu : IPovecajTemperaturu
    {
        private Device d = new Device();
        public void PovecajTemperaturu()
        {
            d.Temperatura += Temperature_difference.temperature_difference;
        }
    }
}
