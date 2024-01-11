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

            Regulator.implementations.Regulacija regulacija = new Regulator.implementations.Regulacija();

            Heater.implementation.Heater heater = new Heater.implementation.Heater();
            regulator.DodajUredjaje();



            var proveraTemp = new Thread(() => regulacija.Regulisi(regulator, heater));
            proveraTemp.Start();
            


        }
    }
}