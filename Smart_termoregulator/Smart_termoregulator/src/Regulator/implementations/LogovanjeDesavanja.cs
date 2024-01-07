using Smart_termoregulator.src.Regulator.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.implementations
{
    public class LogovanjeDesavanja : ILogovanje
    {
        private readonly string fileName = "Thermoregulator_logs.txt";
        
        public void Loguj(string text)
        {
            src.FileUpis.UpisiUtxtFile.UpisiUFile(text, fileName);
        }
    }
}
