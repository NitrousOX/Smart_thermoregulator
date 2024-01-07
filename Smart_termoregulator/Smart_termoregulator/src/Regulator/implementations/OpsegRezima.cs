using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.implementations
{
    internal class OpsegRezima
    {
        private TimeSpan pocetak;
        private TimeSpan kraj;

        public TimeSpan Pocetak { get => pocetak; }
        public TimeSpan Kraj { get => kraj; }

        public OpsegRezima(string sPocetak,string sKraj) {
            pocetak = pretvoriUTimeSpan(sPocetak);
            kraj = pretvoriUTimeSpan(sKraj);
        }

        private TimeSpan pretvoriUTimeSpan(string vremeString)
        {
            TimeSpan vremenskiPeriod;
            int[] vremena = stringUIntVremena(vremeString);
            vremenskiPeriod = new TimeSpan(vremena[0], vremena[1], vremena[2]);

            return vremenskiPeriod;
        }

        private int[] stringUIntVremena(string vremeString)
        {
            int[] vremena = new int[3];
            int i = 0;
            foreach (string broj in vremeString.Split(':'))
            {
                vremena[i++] = Convert.ToInt32(broj);
            }
            return vremena;
        }

        public bool proveraUnutarOpsega()
        {
            TimeSpan sad = DateTime.Now.TimeOfDay;

            if ((TimeSpan.Compare(pocetak, sad) <= 0) && (TimeSpan.Compare(sad, kraj) <= 0))
                return true;

            return false;
        }

    }
}
