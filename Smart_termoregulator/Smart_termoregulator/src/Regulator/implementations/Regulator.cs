using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.implementations
{
    enum rezim_rada { dnevni, nocni }

    public class Regulator
    {
        private rezim_rada rezim;
        private List<Device.implementation.Device>? uredjaji;

        public Regulator()
        {

        }
    }
}
