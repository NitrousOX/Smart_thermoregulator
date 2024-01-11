using Smart_termoregulator.src.Device.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.DeviceTests
{
    public class DeviceProveriHeaterStateTest
    {
        [Fact]
        public void proveriHeaterStateTesting()
        {
            //Arrange - variables
            int id = 1;
            Device device = new Device(id);
            DeviceProveriHeaterState ProveriHeaterState = new DeviceProveriHeaterState();

            //ACT
            ProveriHeaterState.proveriHeaterState(device);
            
            //Assert

        }
    }
}
