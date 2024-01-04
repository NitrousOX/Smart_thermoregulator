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
        private OpsegRezima opsegDnevni, opsegNocni;
        private List<Device.implementation.Device>? uredjaji;

        public Regulator()
        {

        }
    }
}
