using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.implementations
{
    enum rezim_rada { DNEVNI, NOCNI }

    public class Regulator
    {
        private rezim_rada rezim;
        private double tempNocni, tempDnevni;
        private OpsegRezima opsegDnevni;
        private RegulatorRacunajTemp? racunajTemp;
        private float srednjaTemperatura;

        private List<Device.implementation.Device>? uredjaji = new List<Device.implementation.Device>();

        public Regulator(string pocetakRezimaDnevnog, string krajRezimaDnevnog, double nocnaTemp, double dnevnaTRemp) 
        {
            opsegDnevni = new OpsegRezima(pocetakRezimaDnevnog, krajRezimaDnevnog);

            if (opsegDnevni.proveraUnutarOpsega())
                rezim = rezim_rada.DNEVNI;
            else
                rezim = rezim_rada.NOCNI;

            tempNocni  = nocnaTemp;
            tempDnevni = dnevnaTRemp;
        }

        public double TempNocni { get => tempNocni; set => tempNocni = value; }
        public double TempDnevni { get => tempDnevni; set => tempDnevni = value; }
        public List<Device.implementation.Device>? Uredjaji { get => uredjaji; set => uredjaji = value; }
        public float SrednjaTemperatura { get => srednjaTemperatura; set => srednjaTemperatura = value; }
        internal rezim_rada Rezim { get => rezim;}

    }
}
