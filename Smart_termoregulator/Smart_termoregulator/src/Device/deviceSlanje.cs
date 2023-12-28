using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Device
{
    public class deviceSlanje : ISlanjeTemperature  
    {
        private Device d = new Device(0);
        public float PosaljiTemperaturu() {
            return d.Temperatura;
        }

    }
}
