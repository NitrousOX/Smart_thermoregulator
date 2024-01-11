using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src
{
    public class testovi
    {
        public void izmaina()
        {
            Regulator.implementations.RegulatorUI uI = new Regulator.implementations.RegulatorUI();

            Heater.implementation.Heater heater = new Heater.implementation.Heater();

            Regulator.implementations.Regulator regulator = uI.ShowUserInterface();

            regulator.DodajUredjaje();

            Console.WriteLine("dodati uredjaji:");
            for (int i = 0; i < regulator.DeviceNum; i++)
            {
                Console.Write("id: ");
                Console.Write(regulator.Uredjaji[i].Id);
                Console.Write(", temp: ");
                Console.WriteLine(regulator.Uredjaji[i].Temperatura);
            }
            Console.WriteLine("_________________________");

            Console.WriteLine("test srednja temp:");

            regulator.IzracunajSrednjuTemperaturu();
            Console.Write("srednja temp: ");
            Console.WriteLine(regulator.SrednjaTemperatura);

            Console.WriteLine("_________________________");

            Console.WriteLine("test menjanje temp na prvom uredjaju:"); //ne radi jer nije prosledjen heater state
            regulator.Uredjaji[0].DevicePovecajTemperaturu();
            Console.WriteLine(regulator.Uredjaji[0].Temperatura);
            regulator.Uredjaji[0].DeviceSmanjiTemperaturu();
            Console.WriteLine(regulator.Uredjaji[0].Temperatura);

            Console.WriteLine("_________________________");

            Console.WriteLine("test heater upali ugasi:");
            heater.HeaterUpaliGrejanje();
            Thread.Sleep(5000);
            heater.HeaterUgasiGrejanje();

            Console.WriteLine("_________________________");
        }
    }
}
