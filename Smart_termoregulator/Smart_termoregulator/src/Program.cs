using Smart_termoregulator.src.FileUpis;
using Smart_termoregulator.src.Device.implementation;
using Smart_termoregulator.src.Regulator.implementations;


namespace Smart_termoregulator.src
{
    internal class Program
    {
        static void Main(string[] args)
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

            regulator.IzracunajSredjuTemperaturu();
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