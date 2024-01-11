using Smart_termoregulator.src.Device.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Device.interfaces
{
    public interface IPromenaTemperature
    {
        void PovecajTemperaturu(Device.implementation.Device device);
        void SmanjiTemperaturu(Device.implementation.Device device);
    }
}
