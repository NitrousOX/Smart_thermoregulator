using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Smart_termoregulator.src.FileUpis
{
    internal class UpisiUtxtFile
    {
        private string filePath = Directory.GetCurrentDirectory();

        public void UpisiUFile(List<string> text, string fileName)
        {
            filePath = filePath.Replace(@"\bin\Debug\net6.0", @"\logovi\");
            filePath += fileName;

            File.AppendAllLines(filePath, text);
        }
        
    }
}
