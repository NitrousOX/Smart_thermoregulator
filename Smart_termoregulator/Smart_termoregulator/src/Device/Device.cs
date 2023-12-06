using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Device
{
    public class Device
    {
        int id;
        float temperatura;

        Device(float temperatura) {
            this.id = new Random().Next(1, 10000);
            this.Temperatura = temperatura;
        }

        public int ID { get => id; set => id = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }
    }
}
