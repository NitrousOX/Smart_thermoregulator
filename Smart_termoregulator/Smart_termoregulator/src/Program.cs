using Smart_termoregulator.src.FileUpis;


namespace Smart_termoregulator.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
           src.Heater.Heater heater = new src.Heater.Heater();
            heater.HeaterUgasiGrejanje();

            heater.HeaterUpaliGrejanje();
            Thread.Sleep(1000);
            heater.HeaterUpaliGrejanje();
            heater.HeaterUgasiGrejanje();
        }
    }
}