using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Heater.Interfaces
{
    internal interface IPromenaStanja
    {
        void Upali(Heater h);
        void Ugasi(Heater h);
    }
}
