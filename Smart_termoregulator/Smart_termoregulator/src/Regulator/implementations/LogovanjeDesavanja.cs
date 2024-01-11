using Smart_termoregulator.src.Regulator.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.Regulator.implementations
{
    public class LogovanjeDesavanja
    {
        private static readonly string fileName = "Thermoregulator_logs.txt";
        
        public static void Loguj(string text)
        {
            string datumText = "[LOG]\t" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t";
            datumText += text + "\n";
            src.FileUpis.UpisiUtxtFile.UpisiUFile(datumText, fileName);
        }
    }
}
