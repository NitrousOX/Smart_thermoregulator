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

<<<<<<< Updated upstream
        public Device(uint id,float temperatura) {
            this.id = id;
            this.temperatura = temperatura;
=======
        public Device(float temperatura) {
            this.id = new Random().Next(1, 10000);
            this.Temperatura = temperatura;
>>>>>>> Stashed changes
        }

        public uint Id { get => id; set => id = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }
    }
}
