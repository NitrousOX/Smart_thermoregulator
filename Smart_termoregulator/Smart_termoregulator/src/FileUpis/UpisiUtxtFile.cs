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
        

        public static void UpisiUFile(List<string> text, string fileName)
        {
            string filePath = Directory.GetCurrentDirectory();
            filePath = filePath.Replace(@"\bin\Debug\net6.0", @"\logovi\");
            filePath += fileName;

            File.AppendAllLines(filePath, text);
        }
        public static void UpisiUFile(string text, string fileName)
        {
            string filePath = Directory.GetCurrentDirectory();
            filePath = filePath.Replace(@"\bin\Debug\net6.0", @"\logovi\");
            filePath += fileName;

            File.AppendAllText(filePath, text);
        }

    }
}
