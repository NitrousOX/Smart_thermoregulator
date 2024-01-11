using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_termoregulator.src.Device.implementation;

namespace TestProject.DeviceTests
{
    public class DeviceTest
    {
        [Fact]
        public void DeviceTesting()
        {
            //Arrange - variables
            int id = 1;

            //ACT

            Device device = new Device(id);

            //Assert

        }

        [Fact]
        public void DevicePovecajTemperaturuTesting()
        {
            //Arrange - variables
            int id = 1;
            Device device = new Device(id);
            //ACT
            device.DevicePovecajTemperaturu();

            //Assert
        }

            [Fact]
        public void DeviceSmanjiTemperaturuTesting()
        {
             //Arrange - variables
             int id = 1;
             Device device = new Device(id);
             //ACT

             device.DeviceSmanjiTemperaturu();

             //Assert
           
        }
    }
}
