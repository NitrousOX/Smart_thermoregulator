using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.@interface
{
    internal interface IRegulacija
    {
        void Regulisi(src.Regulator.implementations.Regulator r, src.Heater.implementation.Heater heater);    
    }
}
