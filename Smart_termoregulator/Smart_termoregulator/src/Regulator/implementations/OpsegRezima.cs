using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.implementations
{
    internal class OpsegRezima
    {
        private string pocetak;//format: hh:mm:ss
        private string kraj;
        private TimeSpan tPocetak;
        private TimeSpan tKraj;

        public string Pocetak { get => pocetak; set => pocetak = value; }
        public string Kraj { get => kraj; set => kraj = value; }

        public OpsegRezima(string pocetak,string kraj) {
            string[] svremenaPocetak = pocetak.Split('.');
            int[] ivremenaPocetak = new int[3];
            for(int i = 0; i < 3; i++)
            {
                ivremenaPocetak[i] = int.Parse(svremenaPocetak[i]);
            }

            string[] svremenaKraj= kraj.Split('.');
            int[] ivremenaKraj = new int[3];
            for (int i = 0; i < 3; i++)
            {
                ivremenaKraj[i] = int.Parse(svremenaKraj[i]);
            }

            DateTime today = DateTime.Today;



            this.pocetak = pocetak;
            this.kraj = kraj;
        }

        public bool proveraUnutarOpsega()
        {

            return false;
        }

    }
}
