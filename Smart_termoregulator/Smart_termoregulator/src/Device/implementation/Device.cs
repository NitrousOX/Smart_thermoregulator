using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Device.implementation
{
    public class Device
    {
        private uint id;
        private Random rnd = new Random();
        private float temperatura;
        private bool heaterState;

        public Device(uint id)
        {
            this.id = id;
            temperatura = rnd.Next(500, 1500) / 100;
            heaterState = false;
        }

        public Device()
        {
            temperatura = rnd.Next(500, 1500) / 100;
            heaterState = false;
        }

        public uint Id { get => id; set => id = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }
    }

    public static class Temperature_difference
    {
        public const float temperature_difference = 0.01F;
    }
}
