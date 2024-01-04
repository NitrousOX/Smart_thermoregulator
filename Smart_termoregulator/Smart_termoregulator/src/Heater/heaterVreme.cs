using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Heater
{
    public class HeaterVreme
    {
        DateTime start, time;
        TimeSpan protekloVreme;

        public DateTime Start { get => start; set => start = value; }
        public DateTime Time { get => time; set => time = value; }
        public TimeSpan ProtekloVreme { get => protekloVreme; set => protekloVreme = value; }

    }
}
