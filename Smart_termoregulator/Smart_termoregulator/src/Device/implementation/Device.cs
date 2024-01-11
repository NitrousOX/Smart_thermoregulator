using System;
using System.Collections.Generic;
using System.Configuration;
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
        private DevicePromeniTemeraturu promeniTemperaturu;
        private float temperatureDifference;

        public Device(int id)
        {
            this.id = id;
            temperatura = rnd.Next(500, 1500) / 100;
            heaterState = false;
            promeniTemperaturu = new DevicePromeniTemeraturu();

            if (ConfigurationManager.AppSettings["vrednostPromeneTemp"] != null)
            {
                temperatureDifference = float.Parse(ConfigurationManager.AppSettings["vrednostPromeneTemp"]);
            }
            else
            {
                temperatureDifference = 180000;
            }
        }

        public int Id { get => id; set => id = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }

        public float TemperatureDifference => temperatureDifference;

        public bool HeaterState { get => heaterState; set => heaterState = value; }

        public void DevicePovecajTemperaturu()
        {
            if (heaterState)
                promeniTemperaturu.PovecajTemperaturu(this);
        }

        public void DeviceSmanjiTemperaturu() 
        {
            if (!heaterState)
                promeniTemperaturu.SmanjiTemperaturu(this);
        }
    }
}
