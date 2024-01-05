using Smart_termoregulator.src.Regulator.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.implementations
{
    public class RegulatorUI : IUserInterface
    {
        private Regulator regulator = new Regulator();
        public void ShowUserInterface()
        {
            string pattern = "(([01][0-9])|(2[0-3])):[0-5][0-9]:[0-5][0-9]";
            Regex rg = new Regex(pattern);
            string s, pocetak, kraj;

            do
            {
                Console.WriteLine("Unesite vreme koje predstavlja pocetak dnevnog rezima rada(u formatu \"hh:mm:ss\"):");
                pocetak = Console.ReadLine();

                if (!rg.IsMatch(pocetak))
                {
                    Console.WriteLine("Greska kod unosa vremena!\nVreme mora biti u sledecem formatu: hh:mm:ss");
                }
            } while (!rg.IsMatch(pocetak));

            do
            {
                Console.WriteLine("Unesite vreme koje predstavlja kraj dnevnog rezima rada(u formatu \"hh:mm:ss\"):");
                kraj = Console.ReadLine();

                if (!rg.IsMatch(kraj))
                {
                    Console.WriteLine("Greska kod unosa vremena!\nVreme mora biti u sledecem formatu: hh:mm:ss");
                }
            } while (!rg.IsMatch(kraj));

            pattern = "[+-]?[0-9][0-9]";
            rg = new Regex(pattern);

            do
            {
                Console.WriteLine("unesite temperaturu koju zelite tokom dana: ");
                s = Console.ReadLine();
                
                if (!rg.IsMatch(s))
                {
                    Console.WriteLine("Greska kod unosa teamperature!");
                }
            } while (!rg.IsMatch(s));

            double dnevnaTemp = double.Parse(s);
            regulator.TempDnevni = dnevnaTemp;

            do
            {
                Console.WriteLine("unesite temperaturu koju zelite tokom noci: ");
                s = Console.ReadLine();

                if (!rg.IsMatch(s))
                {
                    Console.WriteLine("Greska kod unosa teamperature!");
                }
            } while (!rg.IsMatch(s));

            double nocnaTemp = double.Parse(s);
            regulator.TempNocni = nocnaTemp;

            
        }
    }
}
