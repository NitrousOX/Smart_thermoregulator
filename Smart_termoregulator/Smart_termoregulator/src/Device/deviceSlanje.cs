﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Device
{
    public class DeviceSlanje : ISlanjeTemperature  
    {
        private Device d = new Device();
        public float PosaljiTemperaturu() {
            return d.Temperatura;
        }

    }
}
