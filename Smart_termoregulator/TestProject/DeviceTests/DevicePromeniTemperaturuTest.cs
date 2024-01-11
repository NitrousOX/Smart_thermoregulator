using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_termoregulator.src.Device.implementation;


namespace TestProject.DeviceTests
{
    public class DevicePromeniTemperaturuTest
    {
        [Fact]
        public void PovecajTemperaturuTesting()
        {
            //Arrange - variables
            int id = 1;
            Device device = new Device(id);
            DevicePromeniTemeraturu promeniTemeraturu = new DevicePromeniTemeraturu();
            //ACT
            promeniTemeraturu.PovecajTemperaturu(device);

            //Assert

        }

        [Fact]
        public void SmanjiTemperaturuTesting()
        {
            //Arrange - variables
            int id = 1;
            Device device = new Device(id);
            DevicePromeniTemeraturu promeniTemeraturu = new DevicePromeniTemeraturu();
            //ACT
            promeniTemeraturu.SmanjiTemperaturu(device);

            //Assert

        }
    }
}
