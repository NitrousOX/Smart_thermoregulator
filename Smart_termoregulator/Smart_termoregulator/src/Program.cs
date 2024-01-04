using Smart_termoregulator.src.FileUpis;


namespace Smart_termoregulator.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Heater.implementation.Heater heater = new Heater.implementation.Heater();

            heater.HeaterUpaliGrejanje();
            Thread.Sleep(5000);
            heater.HeaterUgasiGrejanje();
        }
    }
}