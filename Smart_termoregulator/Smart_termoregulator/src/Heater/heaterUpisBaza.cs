using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Heater
{
    public class heaterUpisBaza : IupisUBazu
    { 
        public void UpisiUBazu(HeaterVreme informacijeZaVreme)
        {
            informacijeZaVreme.ProtekloVreme = informacijeZaVreme.Start - informacijeZaVreme.Time;

        }

        public void UpisiUBazuPaljenje(DateTime trenutno)
        {

        }
    }
}
