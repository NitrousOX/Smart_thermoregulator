using Smart_termoregulator.src.Heater.implementation;
using Smart_termoregulator.src.Regulator.implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.HeaterTests
{
    public class HeaterVreme_Tests
    {
        [Fact]
        public void Heater_Vreme_testing()
        {
            HeaterVreme vreme = new HeaterVreme();

            vreme.Start = new DateTime();
            vreme.Time = new DateTime();

            vreme.ProtekloVreme = new TimeSpan();

        }
    }
}
