using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Device.interfaces
{
    public interface IProveraHeaterState
    {
        void proveriHeaterState(Device.implementation.Device device);
    }
}
