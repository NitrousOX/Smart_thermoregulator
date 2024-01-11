using Smart_termoregulator.src.Heater.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.HeaterTests
{
    public class HeaterUpisiTests
    {

        [Fact]
        public void heaterUpisiUbazu_HeaterVreme()
        {
            //Arrange - variables
            heaterUpisBaza upisi = new heaterUpisBaza();
            HeaterVreme vreme = new HeaterVreme();

            vreme.Start = new DateTime(2024,1,12, 14,25,45);
            vreme.Time = new DateTime(2024,1,12, 14,25,46);
            vreme.ProtekloVreme = new TimeSpan(1,3,4);

            //ACT
            upisi.UpisiUBazu(vreme);
          

            //Assert

        }

        [Fact]
        public void heaterUpisiUbazu_trenutno()
        {
            //Arrange - variables
            heaterUpisBaza upisi = new heaterUpisBaza();
            HeaterVreme vreme = new HeaterVreme();

            vreme.Time = new DateTime(2024, 1, 12, 14, 25, 46);


            //ACT
            upisi.UpisiUBazu(vreme.Time);
            //Assert

        }
    }
}
