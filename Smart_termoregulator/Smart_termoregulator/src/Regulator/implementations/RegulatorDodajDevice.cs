using Smart_termoregulator.src.Regulator.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.implementations
{
    public class RegulatorDodajDevice : IDodajDevice
    {        
        public void DodajDevice(Regulator regulator) 
        {
            Random rnd = new Random();
            int deviceNum = regulator.DeviceNum;
            int[] ids = new int[deviceNum];
            int id;

            for (int i = 0; i < deviceNum; i++)
            {
                bool isti = false;
                do
                {
                    id = rnd.Next(0, 1000);
                    if (ids.Contains(id))
                        isti = true;
                    else
                        isti = false;
                } while (isti);

                ids[i] = id;

                Device.implementation.Device device = new Device.implementation.Device(ids[i]);
                regulator.Uredjaji.Add(device);
            }
        }
    }
}
