using Smart_termoregulator.src.Device.implementation;
using Smart_termoregulator.src.Regulator.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.implementations
{
    public class RegulatorRacunajTemp : IRacunajTemperaturu
    {
        private Regulator regulator = new Regulator();

        public void RacunajSrednjuTemperaturu()
        {
            float suma = 0;
            int deviceNum = 0;
            foreach(Device.implementation.Device d in regulator.Uredjaji)
            {
                suma += d.Temperatura;
                deviceNum++;
            }
            regulator.SrednjaTemperatura = suma / deviceNum;
        }
    }
}
