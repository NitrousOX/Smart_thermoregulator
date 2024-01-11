using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_termoregulator.src.Regulator.implementations;
using Smart_termoregulator.src.Heater.implementation;
using Smart_termoregulator.src.Device.implementation;

namespace TestProject.RegulatorTests
{
    public class RegulatorTest
    {
        [Fact]
        public void regulatorTesting()
        {
            //Arrange
            string pocetak = "12:20:30";
            string kraj = "20:20:20";
            double dnevnaTemp = 25;
            double nocnatemp = 19;
            int device_NUM = 4;

            Regulator regulator = new Regulator(pocetak,kraj,dnevnaTemp,nocnatemp,device_NUM);
            //Act

            //Assert
        }
        [Fact]
        public void regulatorTestingDodajUredjaj()
        {
            //Arrange
            string pocetak = "12:20:30";
            string kraj = "20:20:20";
            double dnevnaTemp = 25;
            double nocnatemp = 19;
            int device_NUM = 4;

            Regulator regulator = new Regulator(pocetak, kraj, dnevnaTemp, nocnatemp, device_NUM);
            //Act
            regulator.DodajUredjaje();
            //Assert
        }
        [Fact]
        public void regulatorTestingIzracunajSrednjuTemp()
        {
            //Arrange
            string pocetak = "12:20:30";
            string kraj = "20:20:20";
            double dnevnaTemp = 25;
            double nocnatemp = 19;
            int device_NUM = 4;

            Regulator regulator = new Regulator(pocetak, kraj, dnevnaTemp, nocnatemp, device_NUM);
            List<Device> devices = new List<Device>();
            
            Device novi_uredjaj0 = new Device(0);
            novi_uredjaj0.Temperatura = 5;
            Device novi_uredjaj1 = new Device(1);
            novi_uredjaj1.Temperatura = 10;
            Device novi_uredjaj2 = new Device(2);
            novi_uredjaj2.Temperatura = 8;
            Device novi_uredjaj3 = new Device(3);
            novi_uredjaj3.Temperatura = 5;

            devices.Add(novi_uredjaj0);
            devices.Add(novi_uredjaj1);
            devices.Add(novi_uredjaj2);
            devices.Add(novi_uredjaj3);
            regulator.Uredjaji = devices;
            //Act
            regulator.IzracunajSrednjuTemperaturu();
            //Assert
           

        }


    }
}
