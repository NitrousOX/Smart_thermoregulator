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
        private float temperatura;

        public Device(uint id, float temperatura)
        {
            this.id = id;
            this.temperatura = temperatura;
        }

        public uint Id { get => id; set => id = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }
    }
}
