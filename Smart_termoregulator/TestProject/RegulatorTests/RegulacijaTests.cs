using Smart_termoregulator.src.Heater.implementation;
using Smart_termoregulator.src.Regulator.implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.RegulatorTests
{
    public class RegulacijaTests
    {
        [Fact]
        public void RegulacijaTesting()
        {
            ///Mora da se koristi Mock
            string pocetak = "12:20:30";
            string kraj = "20:20:20";
            double dnevnaTemp = 25;
            double nocnatemp = 19;
            int device_NUM = 4;

            Regulator regulator = new Regulator(pocetak, kraj, dnevnaTemp, nocnatemp, device_NUM);

            Heater heater = new Heater();

            Regulacija reg = new Regulacija();
            reg.Regulisi(regulator, heater);


        }
    }
}
