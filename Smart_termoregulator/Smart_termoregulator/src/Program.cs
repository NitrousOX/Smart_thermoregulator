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

            Thread[] proveraState = new Thread[regulator.DeviceNum];

            for (int i=0; i<regulator.DeviceNum; i++)
            {
                int localnum = i;
                proveraState[i] = new Thread(() => proveriHeaterState.proveriHeaterState(regulator.Uredjaji[localnum]));
            }

            for (int i = 0; i < regulator.DeviceNum; i++)
            {
                proveraState[i].Start();
            }


        }
    }
}