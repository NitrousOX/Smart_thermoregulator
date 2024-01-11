using Smart_termoregulator.src.FileUpis;
using Smart_termoregulator.src.Device.implementation;


namespace Smart_termoregulator.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regulator.implementations.RegulatorUI uI = new Regulator.implementations.RegulatorUI();
           src.Regulator.implementations.Regulator regulator = uI.ShowUserInterface();

            
            Random rnd = new Random();
            int deviceNum = 4;
            int[] ids = new int[deviceNum];

            for (int i = 0; i < deviceNum; i++)
            {
                bool isti = false;
                do
                {
                    ids[i] = rnd.Next(0, 100);
                    foreach (int id in ids)
                    {
                        if (id != ids[i])
                            isti = false;
                    }
                } while (isti);

                Device.implementation.Device device = new Device.implementation.Device(ids[i]);
                regulator.Uredjaji.Add(device);

                foreach (int id in ids)
                {
                    if (id == ids[i])
                        isti = true;
                }
            }
            Console.WriteLine(regulator.Uredjaji[0].Temperatura);
            regulator.Uredjaji[0].DevicePovecajTemperaturu();
            Console.WriteLine(regulator.Uredjaji[0].Temperatura);
            

            Heater.implementation.Heater heater = new Heater.implementation.Heater();

            heater.HeaterUpaliGrejanje();
            Thread.Sleep(5000);
            heater.HeaterUgasiGrejanje();
        }
    }
}