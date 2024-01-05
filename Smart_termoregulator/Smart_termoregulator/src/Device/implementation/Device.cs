using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Device.implementation
{
    public class Device
    {
        private int id;
        private Random rnd = new Random();
        private float temperatura;
        private bool heaterState;
        private const float temperatureDifference = 0.01F;
        private DevicePromeniTemeraturu promeniTemperaturu;

        public Device(int id)
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

        public int Id { get => id; set => id = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }

        public float TemperatureDifference => temperatureDifference;

        public bool HeaterState { set => heaterState = value; }

        public void DevicePovecajTemperaturu()
        {
            if (heaterState)
                promeniTemperaturu.PovecajTemperaturu();
        }

        public void DeviceSmanjiTemperaturu() 
        {
            if (!heaterState)
                promeniTemperaturu.SmanjiTemperaturu();
        }
    }
}
