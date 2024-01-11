using Smart_termoregulator.src.Regulator.implementations;
using Smart_termoregulator.src.Heater.implementation;
using Smart_termoregulator.src.Device.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.RegulatorTests
{
    public class RegulatorDodajDeviceTest
    {
        [Fact]
        public void DodajDeviceTesting()
        {
            //Arrange
            string pocetak = "12:20:30";
            string kraj = "20:20:20";
            double dnevnaTemp = 25;
            double nocnatemp = 19;
            int device_NUM = 4;

            Regulator regulator = new Regulator(pocetak, kraj, dnevnaTemp, nocnatemp, device_NUM);
            RegulatorDodajDevice regulatorDodajDevice = new RegulatorDodajDevice();
            //Act
            regulatorDodajDevice.DodajDevice(regulator);
            //Assert
        }
    }
}
