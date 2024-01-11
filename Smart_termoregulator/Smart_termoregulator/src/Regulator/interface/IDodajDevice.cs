using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.@interface
{
    public interface IDodajDevice
    {
        void DodajDevice(Regulator.implementations.Regulator regulator);
    }
}
