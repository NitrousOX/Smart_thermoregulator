using Smart_termoregulator.src.FileUpis;
using Smart_termoregulator.src.Device.implementation;
using Smart_termoregulator.src.Regulator.implementations;
using Smart_termoregulator.src.Heater.implementation;


namespace Smart_termoregulator.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regulator.implementations.RegulatorUI uI = new Regulator.implementations.RegulatorUI();

            Regulator.implementations.Regulator regulator = uI.ShowUserInterface();

            Heater.implementation.Heater heater = new Heater.implementation.Heater();

            Regulator.implementations.Regulacija regulacija = new Regulator.implementations.Regulacija();

            Device.implementation.DeviceProveriHeaterState proveriHeaterState = new Device.implementation.DeviceProveriHeaterState();

            regulator.DodajUredjaje();

            var proveraTemp = new Thread(() => regulacija.Regulisi(regulator, heater));
            proveraTemp.Start();

            for(int i=0; i<regulator.DeviceNum; i++)
            {
                var proveraState = new Thread(() => proveriHeaterState.proveriHeaterState(regulator.Uredjaji[i]));
                proveraState.Start();
            }
            

        }
    }
}