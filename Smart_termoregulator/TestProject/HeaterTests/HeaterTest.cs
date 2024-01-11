using Smart_termoregulator.src.Heater.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_termoregulator.src.Heater.implementation;

namespace TestProject.HeaterTests
{
    
    public class HeaterTest
    {
        [Fact]
        public void heaterPromenaStanja_Upali()
        {
            //Arrange - variables
            Heater heater = new Heater();
            //ACT
            //mora da se koristi mock
            heater.HeaterUpaliGrejanje();

            //Assert
            
        }
    }
}
