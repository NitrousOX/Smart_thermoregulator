using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Device
{
    public class Device
    {
        private uint id;
        private Random Rnd = new Random();
        private float temperatura;

        public Device(uint id)
        {
            this.id = id;
            this.temperatura =  Rnd.Next(500, 1500) / 100;
        }

        public uint Id { get => id; set => id = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }
    }
}
