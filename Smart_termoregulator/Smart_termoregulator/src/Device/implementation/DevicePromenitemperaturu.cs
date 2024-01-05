using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_termoregulator.src.Device.interfaces;

namespace Smart_termoregulator.src.Device.implementation
{
    public class DevicePromeniTemeraturu : IPromenaTemperature
    {
        private Device device = new Device();

        public void PovecajTemperaturu()
        {
            device.Temperatura += device.TemperatureDifference;
        }

        public void SmanjiTemperaturu()
        {
            device.Temperatura -= device.TemperatureDifference;
        }
    }
}
